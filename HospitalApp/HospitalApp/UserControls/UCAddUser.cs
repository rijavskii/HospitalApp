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

namespace HospitalApp.UserControls
{
    public partial class UCAddUser : UserControl
    {
        public UCAddUser()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ValidatePatient()
        {
            bool isValid = true;

            if (tbFirstName.Text.Length < 3)
            {
                tbFirstName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbFirstName.BackColor = Color.White;
            }

            if (tbMiddleName.Text.Length < 3)
            {
                tbMiddleName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbMiddleName.BackColor = Color.White;
            }

            if (tbLastName.Text.Length < 3)
            {
                tbLastName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbLastName.BackColor = Color.White;
            }

            if (mtbPassportSeries.Text.Trim().Length < 2)
            {
                mtbPassportSeries.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                mtbPassportSeries.BackColor = Color.White;
            }

            if (mtbPassportNumber.Text.Trim().Length < 6)
            {
                mtbPassportNumber.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                mtbPassportNumber.BackColor = Color.White;
            }

            if (mtbInnNumber.Text.Trim().Length < 10)
            {
                mtbInnNumber.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                mtbInnNumber.BackColor = Color.White;
            }

            if (tbCountry.Text.Trim() == String.Empty)
            {
                tbCountry.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbCountry.BackColor = Color.White;
            }

            if (tbDistrict.Text.Trim() == String.Empty)
            {
                tbDistrict.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbDistrict.BackColor = Color.White;
            }

            if (tbCity.Text.Trim() == String.Empty)
            {
                tbCity.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbCity.BackColor = Color.White;
            }

            if (tbStreet.Text.Trim() == String.Empty)
            {
                tbStreet.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbStreet.BackColor = Color.White;
            }

            if (tbHouseNumber.Text.Trim() == String.Empty)
            {
                tbHouseNumber.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbHouseNumber.BackColor = Color.White;
            }

            if (tbAppartment.Text.Trim() == String.Empty)
            {
                tbAppartment.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbAppartment.BackColor = Color.White;
            }

            return isValid;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (ValidatePatient())
            {
                var context = new HospitalDbContext();
                string passport = mtbPassportSeries.Text + mtbPassportNumber.Text;
                var myAdress = new Adresses()
                {
                    Country = tbCountry.Text,
                    District = tbDistrict.Text,
                    Region = tbRegion.Text,
                    City = tbCity.Text,
                    HouseNumber = tbHouseNumber.Text,
                    Street = tbStreet.Text,
                    Appartment = Convert.ToInt32(tbAppartment.Text)
                };



                context.Users.Add(new Users()
                {
                    FirstName = tbFirstName.Text,

                    LastName = tbLastName.Text,
                    Birthday = dtpBirthday.Value,
                    Passport = passport,
                    IdentificationNumber = mtbInnNumber.Text,
                    IsPatient = true,
                    Adress = myAdress,
                    Position = context.Positions.First(x => x.Name == "Undefined"),

                    Login = tbLastName.Text + " " + tbFirstName.Text,
                    Password = tbLastName.Text + " " + tbStreet.Text + " " + tbHouseNumber.Text

                });

                context.SaveChanges();
                MessageBox.Show("Patient " + tbFirstName.Text + " " + tbLastName.Text + " was succefully created!",
                    "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
