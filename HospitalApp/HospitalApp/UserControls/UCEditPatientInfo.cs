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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCEditPatientInfo'
    public partial class UCEditPatientInfo : UserControl
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCEditPatientInfo'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'UCEditPatientInfo.UCEditPatientInfo()'
        public UCEditPatientInfo()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'UCEditPatientInfo.UCEditPatientInfo()'
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
        }

        private void lbInnNumber_Click(object sender, EventArgs e)
        {

        }

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


            //if (tbPassportSeries.Text.Length != 2)
            //{
            //    tbPassportSeries.BackColor = Color.Red;
            //    isValid = false;
            //}
            //if (tbPassportNunber.Text.Length != 6)
            //{
            //    tbPassportNunber.BackColor = Color.Red;
            //    isValid = false;
            //}
            //if (tbInnNumber.Text.Length != 10)
            //{
            //    tbInnNumber.BackColor = Color.Red;
            //    isValid = false;
            //}

            return isValid;
        }
    }
}
