using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCFindPatient'
    public partial class UCFindPatient : UserControl
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCFindPatient'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCFindPatient.UCFindPatient()'
        public UCFindPatient()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCFindPatient.UCFindPatient()'
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scFindPatient_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool validatePatient()
        {
            bool isValid = true;

            if (tbFirstName.Text.Length < 3)
            {
                tbFirstName.BackColor = Color.Red;
            }
            if (tbMiddleName.Text.Length < 3)
            {
                tbMiddleName.BackColor = Color.Red;
            }
            if (tbLastName.Text.Length < 3)
            {
                tbLastName.BackColor = Color.Red;
            }
            return isValid;
        }
    }
}
