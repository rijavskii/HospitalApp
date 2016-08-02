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
                        //(openFile.FileName);
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
            
            
            foreach (var medicine in linesMedicine)
            {
                var drugs = medicine.Split(';').ToList();

            }
        }
    }
}
