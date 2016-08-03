using EntityDb.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.DAL;

namespace HospitalApp
{
    /// <summary>
    /// Main application form
    /// </summary>
    public partial class CoreForm : Form
    {
        /// <summary>
        /// Creates form initializer
        /// </summary>
        public CoreForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Export medicines from .txt, .csv files into program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a File.
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files|*.txt|CSV Files|*.csv";
            saveFile.Title = "Export Medicine";
            
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|CSV Files|*.csv";
            openFileDialog.Title = "Import Medicine";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (openFileDialog.FilterIndex)
                {
                    case 1:
                        TxtParseMethod(openFileDialog.FileName);
                        break;
                    case 2:
                        CsvParseMethod(openFileDialog.FileName);
                        break;
                }
            }
        }

        private void CsvParseMethod(string fileName)
        {
            var fileContent = File.ReadAllText(fileName, Encoding.GetEncoding("UTF-8"));
            var linesMedicine = fileContent.Split(Environment.NewLine.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var nameFields = linesMedicine.ElementAt(0).Split(',').ToList();
                linesMedicine.RemoveAt(0);

            int nameMedicine = nameFields.FindIndex(x=>x.Trim().Equals("Name"));
            int typeMedicine = nameFields.FindIndex(x => x.Trim().Equals("MedicineType"));
            int manufacturerName = nameFields.FindIndex(x => x.Trim().Equals("Manufacturer"));
            int manufacturerCountry = nameFields.FindIndex(x => x.Trim().Equals("Country"));

            using (var context = new HospitalDbContext())
            {
                foreach (var item in linesMedicine)
                {
                    var medItems = item.Split(',').ToList();

                    context.Medicines.Add(new Medicine()
                    {
                        Name = medItems[nameMedicine],
                        Manufacturer = new Manufacturer()
                        {
                            FactoryName = medItems[manufacturerName],
                            Country = medItems[manufacturerCountry]
                        },
                        MedicineType = new MedicineType()
                        {
                            Name = medItems[typeMedicine]
                        }
                    });
                }
                context.SaveChanges();
            }
            
        }

        private void TxtParseMethod(string fileName)
        {
            var fileContent = File.ReadAllText(fileName, Encoding.GetEncoding("UTF-8"));
            List<string> stringMedicine = fileContent.Split(Environment.NewLine.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Drugs> MedDrug = new List<Drugs>();

            foreach (var item in stringMedicine)
            {
                var medItems = item.Split(',').ToList();

                Drugs itemMedicine = new Drugs();
                itemMedicine.Name.Name = medItems[0];
                itemMedicine.Manufacturers.FactoryName = medItems[1];
                itemMedicine.Manufacturers.Country = medItems[2];
                itemMedicine.Type.Name = medItems[3];

                MedDrug.Add(itemMedicine);
            }
                 
        }
        //TODO ADD DB
        private void AddTextToDb(string fileName) { 
            using (var context = new HospitalDbContext())
            {
                var fileContent = File.ReadAllText(fileName, Encoding.GetEncoding("UTF-8"));
                List<string> stringMedicine = fileContent.Split(Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            
                foreach (var item in stringMedicine)
                {
                    var medItems = item.Split(',').ToList();

                    context.Medicines.Add(new Medicine()
                    {
                        Name = medItems[0],
                        Manufacturer = new Manufacturer()
                        {
                            FactoryName = medItems[1],
                            Country = medItems[2]
                        },
                        MedicineType = new MedicineType()
                        {
                            Name = medItems[3]
                        }
                    });
                }
                context.SaveChanges();
            }
        }

        private void SaveToTxtMethod(string fileName)
        {
            var context = new HospitalDbContext();
            var listMedicines = context.Medicines.ToList();

            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                using (var fileWrite = new StreamWriter(fileStream))
                {
                    foreach (var medItem in listMedicines)
                    {
                        fileWrite.Write(medItem + Environment.NewLine);
                    }
                    fileWrite.Close();
                }
                fileStream.Close();
            }

            //throw new NotImplementedException();
        }

        //TODO 
        private void SaveToCsvMethod(string fileName)
        {
            var context = new HospitalDbContext();
            var listMedicines = context.Medicines.ToList();
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write("Name, Manufacturer, Country, Type {0}",Environment.NewLine);
                    foreach (var drug in listMedicines)
                    {
                        streamWriter.Write("{0}, {1}, {2}, {3}, {4}", 
                            drug.Name, drug.Manufacturer.FactoryName,
                            drug.Manufacturer.Country, drug.MedicineType.Name,
                            Environment.NewLine);
                    }
                }
                
            }
           // MessageBox.Show()
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
