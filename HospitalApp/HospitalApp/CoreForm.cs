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
            using (var csvParse = new FileStream(fileName, FileMode.Open))
            {
                
            }
        }
        private void TxtParseMethod(string fileName)
        {
            string fileText = File.ReadAllText(fileName);
            List<string> stringMedicine = fileText.Split(Environment.NewLine.ToCharArray()).ToList();

            List<Medicine> MedDrug = new List<Medicine>();

            foreach (var item in stringMedicine)
            {
                var medItems = item.Split(',').ToList();

                Medicine itemMedicine = new Medicine();

                itemMedicine.Name = medItems[0];
                itemMedicine.FactoryName = medItems[1];
                itemMedicine.FactoryCountry = medItems[2];
                itemMedicine.TypeName = medItems[3];

                MedDrug.Add(itemMedicine);
            }

        }

           
    }
}
