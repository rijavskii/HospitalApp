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

    public partial class UCEditPatientInfo : UserControl
    {

        public UCEditPatientInfo()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Today;
        }

        private void lbInnNumber_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Check if all information about user is correct for saving
        /// </summary>
        /// <returns></returns>
        public bool UserValidation()
        {
            bool isValid = true;

            if (tbFirstName.Text.Length < 3)
            {
                tbFirstName.BackColor = Color.Red;
                isValid = false;
            }
            if (tbMiddleName.Text.Length < 3)
            {
                tbMiddleName.BackColor = Color.Red;
                isValid = false;
            }
            if (tbLastName.Text.Length < 3)
            {
                tbLastName.BackColor = Color.Red;
                isValid = false;
            }

            if (tbPassportSeries.Text.Length != 2)
            {
                tbPassportSeries.BackColor = Color.Red;
                isValid = false;
            }
            if (tbPassportNunber.Text.Length != 6)
            {
                tbPassportNunber.BackColor = Color.Red;
                isValid = false;
            }
            if (tbInnNumber.Text.Length != 10)
            {
                tbInnNumber.BackColor = Color.Red;
                isValid = false;
            }

            return isValid;
        }
    }
}
