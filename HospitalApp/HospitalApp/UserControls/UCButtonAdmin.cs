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
    /// <summary>
    /// 
    /// </summary>
    public partial class UcButtonAdmin : UserControl
    {
        private readonly Panel _panel;
        private readonly int _position;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="myPanel"></param>
        /// <param name="id"></param>
        public UcButtonAdmin(Panel myPanel, int id )
        {
            InitializeComponent();

            _position = id;
            _panel = myPanel;

            btnCreateWorker.PerformClick();

            //toolTip1.SetToolTip(tsBtnDocButtons,"Doctor interface");
        }

        private void tsBtnRegBut_Click(object sender, EventArgs e)
        {
            pnlButtons.Controls.Clear();
            _panel.Controls.Clear();
            tlpAdminBtns.Visible = false;
            pnlButtons.Controls.Add(new UcButtonRegistry(_panel));

            lblInterface.Text = @"Registry interface";
            
        }

        private void tsBtnDocButtons_Click(object sender, EventArgs e)
        {
            pnlButtons.Controls.Clear();
            _panel.Controls.Clear();

            tlpAdminBtns.Visible = false;
            pnlButtons.Show();

            pnlButtons.Controls.Add(new UcButtonDoctor(_panel, _position));

            lblInterface.Text = @"Doctor interface";

        }

        private void tsBtnAdminButtons_Click(object sender, EventArgs e)
        {
            pnlButtons.Controls.Clear();
            _panel.Controls.Clear();

            tlpAdminBtns.Visible = true;
            pnlButtons.Controls.Add(tlpAdminBtns);

            btnCreateWorker.PerformClick();
            lblInterface.Text = @"Admin interface";
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
