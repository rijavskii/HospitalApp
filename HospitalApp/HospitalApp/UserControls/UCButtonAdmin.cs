using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.UserControls
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCButtonAdmin'
    public partial class UcButtonAdmin : UserControl
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCButtonAdmin'
    {
        private Panel _panel;
        private readonly int position;
        public UcButtonAdmin(Panel myPanel, int id )
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCButtonAdmin.UCButtonAdmin()'
        {
            InitializeComponent();

            position = id;
            _panel = myPanel;


            //toolTip1.SetToolTip(tsBtnDocButtons,"Doctor interface");
        }

        private void tsBtnRegBut_Click(object sender, EventArgs e)
        {
           pnlButtons.Controls.Clear();
           tlpAdminBtns.Visible = false;
           pnlButtons.Controls.Add(new UcButtonRegistry(_panel));
        }

        private void tsBtnDocButtons_Click(object sender, EventArgs e)
        {
            pnlButtons.Controls.Clear();
            tlpAdminBtns.Visible = false;
            pnlButtons.Show();
            
            pnlButtons.Controls.Add(new UcButtonDoctor(_panel, position));
        }

        private void tsBtnAdminButtons_Click(object sender, EventArgs e)
        {
            pnlButtons.Controls.Clear();
            tlpAdminBtns.Visible = true;
            pnlButtons.Controls.Add(tlpAdminBtns);
            
        }

        private void btnCreateWorker_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(new UcAddWorker());
        }

        private void btnFindWorker_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(new UcFindWorker());
        }
    }
}
