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

    public partial class UCListMedicine : UserControl
    {

        public UCListMedicine()
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

                    listView1.Items.Add(items);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
