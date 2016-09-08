using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
        /// <summary>
        /// Constructor
        /// </summary>
        public UcListMedicine()
        {
            InitializeComponent();
            AddDrugsToListView();
        }

        private void AddDrugsToListView()
        {
            List<Medicine> allDrugs;
            using (var context = new HospitalDbContext())
            {
                allDrugs = context.Medicines.ToList();


                foreach (var allDrug in allDrugs)
                {
                    var items = new ListViewItem(allDrug.Name);
                    items.SubItems.Add(allDrug.Manufacturer.FactoryName);
                    items.SubItems.Add(allDrug.Manufacturer.Country);
                    items.SubItems.Add(allDrug.MedicineType.Name);

                    lvDrugs.Items.Add(items);
                }
            }
        }
        
    }
}
