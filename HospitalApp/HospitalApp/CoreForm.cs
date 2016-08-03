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
    /// 
    /// </summary>
    public partial class CoreForm : Form
    {
        /// <summary>
        /// 
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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files|*.txt|CSV Files|*.csv";
            openFile.Title = "Export Medicine";
            
            // Show the Dialog.
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                switch (openFile.FilterIndex)
                {
                    case 1:
                        TxtParseMethod(openFile.FileName);
                        break;
                    case 2:
                        CsvParseMethod(openFile.FileName);
                        break;
                }
            }
        }

        private void CsvParseMethod(string fileName)
        {
            var fileContent = File.ReadAllText(fileName);
            var linesMedicine = fileContent.Split(Environment.NewLine.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var nameFields = linesMedicine.ElementAt(0).Split(';').ToList();
                linesMedicine.RemoveAt(0);

            int nameMedicine = nameFields.IndexOf("Name");
            int typeMedicine = nameFields.IndexOf("Type");
            int manufacturerName = nameFields.IndexOf("Manufacturer Name");
            int manufacturerCountry = nameFields.IndexOf("Country");

            using (var context = new HospitalDbContext())
            {
                foreach (var item in nameFields)
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
            }
            
        }

        private void TxtParseMethod(string fileName)
        {
            string fileText = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            List<string> stringMedicine = fileText.Split(Environment.NewLine.ToCharArray(),
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

        private void importMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|CSV Files|*.csv";
            saveFileDialog.Title = "Import Medicine";

            var context = new HospitalDbContext();
            var listMedicines = context.Set<Medicine>();
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        SaveToTxtMethod(saveFileDialog.FileName);
                        break;
                    case 2:
                        SaveToCsvMethod(saveFileDialog.FileName);
                        break;
                }

            }
            
        }

        private void SaveToTxtMethod(string fileName)
        {
            throw new NotImplementedException();
        }

        private void SaveToCsvMethod(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
