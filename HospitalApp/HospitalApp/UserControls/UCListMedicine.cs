﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    /// <summary>
    /// Show all drugs in database
    /// </summary>
    public partial class UcListMedicine : UserControl
    {
        //ToDo Naming convention!!!
        private List<Medicine> allDrugs ;
        /// <summary>
        /// Constructor
        /// </summary>
        public UcListMedicine()
        {
            InitializeComponent();
            using (var context = new HospitalDbContext())
            {
                allDrugs = context.Medicines.OrderByDescending(x => x.Name).ToList();
                AddDrugsToListView();
            }
        }

        private void AddDrugsToListView()
        {

            lvDrugs.Items.Clear();
            
                foreach (var allDrug in allDrugs)
                {
                    var items = new ListViewItem(allDrug.Name);
                    items.SubItems.Add(allDrug.Manufacturer.FactoryName.Trim());
                    items.SubItems.Add(allDrug.Manufacturer.Country.Trim());
                    items.SubItems.Add(allDrug.MedicineType.Name.Trim());

                    lvDrugs.Items.Add(items);
                }
            
        }

        private void lvDrugs_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            //Point mousePosition = lvDrugs.PointToClient(Control.MousePosition);
            //ListViewHitTestInfo hit = lvDrugs.HitTest(mousePosition);
            //int columnIndex = hit.Item.SubItems.IndexOf(hit.SubItem);
            //SortListView(columnIndex);
            var lv = lvDrugs.Sorting == SortOrder.Ascending;
            var f = chManufacturer.ListView.Sorting == SortOrder.Descending;
        }

        private void SortListView(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    allDrugs = allDrugs.OrderByDescending(x => x.Name).ToList();
                    AddDrugsToListView();
                    break;
                case 1:
                    allDrugs = allDrugs.OrderByDescending(x => x.Manufacturer.FactoryName).ToList();
                    AddDrugsToListView();
                    break;
                case 2:
                    allDrugs = allDrugs.OrderByDescending(x => x.MedicineType.Name).ToList();
                    AddDrugsToListView();
                    break;
                case 3:
                    allDrugs = allDrugs.OrderByDescending(x => x.Manufacturer.Country).ToList();
                    AddDrugsToListView();
                    break;
            }
        }

        /// <summary>
        /// Export medicines from .txt, .csv files into program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a File.
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Text Files|*.txt|CSV Files|*.csv",
                Title = "Export Medicine"
            };

            // Show the Dialog.
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                switch (saveFile.FilterIndex)
                {
                    case 1:
                        SaveToTxtMethod(saveFile.FileName);
                        break;
                    case 2:
                        SaveToCsvMethod(saveFile.FileName);
                        break;
                }
            }
        }

        /// <summary>
        /// Open file dialog for choosing file with medicine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt|CSV Files|*.csv",
                Title = "Import Medicine"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (openFileDialog.FilterIndex)
                {
                    case 1:
                        TxtParseMethod(openFileDialog.FileName);
                        break;
                    case 2:
                        ParseAndAddCsvToDb(openFileDialog.FileName);
                        break;
                }
            }
        }

        /// <summary>
        /// Method for parsing csv and adding parsed list to database
        /// </summary>
        /// <param name="fileName">full name of working file</param>
        private void ParseAndAddCsvToDb(string fileName)
        {
            pbLoading.Visible = true;
            this.Enabled = false;

            //Todo Use Encoding.Utf8, not  Encoding.GetEncoding("UTF-8")
            var fileContent = File.ReadAllText(fileName, Encoding.UTF8);
            var linesMedicine = fileContent.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var nameFields = linesMedicine.ElementAt(0).Split(',').ToList();
            linesMedicine.RemoveAt(0);

            var refMed = typeof(Medicine).GetProperties();
            var refMan = typeof(Manufacturer).GetProperties();
            var refTypeMed = typeof(MedicineType).GetProperties();

            int nameMedicine = nameFields.FindIndex(x => x.Trim().Equals(refMed[0].Name));
            int typeMedicine = nameFields.FindLastIndex(x => x.Trim().Equals(refTypeMed[0].Name));
            int manufacturerName = nameFields.FindIndex(x => x.Trim().Equals(refMan[0].Name));
            int manufacturerCountry = nameFields.FindIndex(x => x.Trim().Equals(refMan[1].Name));

            using (var context = new HospitalDbContext())
            {
                foreach (var item in linesMedicine)
                {
                    List<string> medItems = item.Split(',').ToList();
                    string nameC = medItems[manufacturerCountry].Trim();
                    //string nameF = medItems[manufacturerName].Trim();
                    
                    //Manufacturer ifexist=null;
                    //MedicineType drugType=null;

                    MedicineType drugType = new MedicineType()
                    {
                        Name = medItems[typeMedicine]
                    };
                    Manufacturer manufacturer = new Manufacturer()
                    {
                        FactoryName = medItems[manufacturerName].Trim(),
                        Country = medItems[manufacturerCountry].Trim()
                    };
                    context.Manufacturers.AddIfNoExists(manufacturer);
                    //context.MedicineType.AddOrUpdate(drugType);
                    context.SaveChanges();
                    //Name = medItems[typeMedicine];
                    context.Medicines.Add(new Medicine()
                    {
                        Name = medItems[nameMedicine].Trim(),
                        Manufacturer = manufacturer,
                        MedicineType = drugType
                    });
                }
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException a)
                {
                    ShowErrors(a);
                    throw;
                }
            }

            this.pbLoading.Visible = false;
            this.Enabled = true;

            var name = fileName.Split('\\').Last();
            MessageBox.Show("File " + name + " imported!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrors(DbEntityValidationException a)
        {
            foreach (var eve in a.EntityValidationErrors)
            {
                MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name + "\" in state \"" + eve.Entry.State + "\" has the following validation errors:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var ve in eve.ValidationErrors)
                {
                    MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Error: \"" + ve.ErrorMessage + "\"", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                }
            }
        }

        /// <summary>
        /// Read and parse data about drugs from *.txt file
        /// </summary>
        /// <param name="fileName"></param>
        private void TxtParseMethod(string fileName)
        {
            pbLoading.Visible = true;
            this.Enabled = false;

            var fileContent = File.ReadAllText(fileName, Encoding.UTF8);

            List<string> stringMedicine = fileContent.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Drugs> medDrug = new List<Drugs>();

            foreach (var item in stringMedicine)
            {
                var medItems = item.Split(',').ToList();

                Drugs itemMedicine = new Drugs
                {
                    Name = medItems[0],
                    Manufacturers = new Manufacturer()
                    {
                        FactoryName = medItems[1],
                        Country = medItems[2]
                    },
                    Type = new MedicineType() { Name = medItems[3] }
                };

                medDrug.Add(itemMedicine);
            }
            var name = fileName.Split('\\').Last();
            AddDrugToDb(medDrug, name);
        }

        /// <summary>
        /// method to add info in DataBase
        /// "UTF-8" - doesn't work. Work only Encoding.GetEncoding(1251)
        /// Adding list of drugs to database
        /// Export medicines to database from *.txt file
        /// </summary>
        /// <param name="medDrug">List of drugs which need to be saved</param>
        /// <param name="name">short name of file we read</param>
        private void AddDrugToDb(List<Drugs> medDrug, string name)
        {
            using (var context = new HospitalDbContext())
            {
                foreach (var item in medDrug)
                {
                    context.Medicines.Add(new Medicine()
                    {
                        Name = item.Name,
                        Manufacturer = new Manufacturer()
                        {
                            FactoryName = item.Manufacturers.FactoryName,
                            Country = item.Manufacturers.Country,
                        },
                        MedicineType = new MedicineType()
                        {
                            Name = item.Type.Name
                        }
                    });
                }
                context.SaveChanges();
            }

            MessageBox.Show("File " + name + " imported!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.pbLoading.Visible = false;
            this.Enabled = true;
        }

        /// <summary>
        /// Export medicines from database to *.txt file
        /// </summary>
        /// <param name="fileName">Full path for saving file</param>
        private void SaveToTxtMethod(string fileName)
        {
            var context = new HospitalDbContext();
            var listMedicines = context.Medicines.ToList();

            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                using (var fileWrite = new StreamWriter(fileStream))
                {
                    foreach (var drug in listMedicines)
                    {
                        fileWrite.Write("{0}, {1}, {2}, {3}, {4}", drug.Name, drug.Manufacturer.FactoryName, drug.Manufacturer.Country, drug.MedicineType.Name, Environment.NewLine);
                    }
                    fileWrite.Close();
                }
                fileStream.Close();
            }
            //throw new NotImplementedException();

            var name = fileName.Split('\\').Last();
            MessageBox.Show("File " + name + " was succefully created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Export medicines from database to *.csv file
        /// </summary>
        /// <param name="fileName">Full path for saving file</param>
        private void SaveToCsvMethod(string fileName)
        {
            var name = fileName.Split('\\').Last();
            var context = new HospitalDbContext();
            var listMedicines = context.Medicines.ToList();
            var size = listMedicines.Count;

            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    //var da = typeof(Medicine).GetProperties()[0].Name;
                    //var b = typeof(Manufacturer).GetProperties()[0].Name;
                    
                    //var ca = typeof(Manufacturer).GetProperties()[1].Name;
                    //var d = typeof(MedicineType).GetProperties()[0].Name;

                    streamWriter.Write("{0}, {1}, {2}, {3} {4}", typeof(Medicine).GetProperties()[0].Name, 
                                                                 typeof(Manufacturer).GetProperties()[0].Name, 
                                                                 typeof(Manufacturer).GetProperties()[1].Name, 
                                                                 typeof(MedicineType).GetProperties()[0].Name, 
                                                                 Environment.NewLine);

                    foreach (var drug in listMedicines)
                    {
                        streamWriter.Write("{0}, {1}, {2}, {3}, {4}", drug.Name, drug.Manufacturer.FactoryName, drug.Manufacturer.Country, drug.MedicineType.Name, Environment.NewLine);
                    }
                }
            }
            MessageBox.Show("File " + name + " was succefully created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
