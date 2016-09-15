using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalApp.UserControls;

namespace HospitalApp
{

    /// <summary>
    /// 
    /// </summary>
    public partial class UcButtonRegistry : UserControl
    {
        //ToDO check if you realy need to use this Panel
        private Panel work;
        /// <summary>
        /// 
        /// </summary>
        public UcButtonRegistry(Panel myPanel)
        {
            InitializeComponent();
            work = myPanel;
            btnNewPatient.PerformClick();
        }

        

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            work.Controls.Clear();
            work.Controls.Add(new UcAddUser());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
          work.Controls.Clear();
          work.Controls.Add(new UcFindPatient());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
