using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    

    public partial class UCButtonDoctor : UserControl
    {
        private Panel myPanel;

        public UCButtonDoctor(Panel _panel)
        {
            InitializeComponent();
            myPanel = _panel;
        }

        

        private void btListMedicine_Click(object sender, EventArgs e)
        {
            myPanel.Controls.Clear();
            myPanel.Controls.Add(new UCListMedicine());
        }
    }
}
