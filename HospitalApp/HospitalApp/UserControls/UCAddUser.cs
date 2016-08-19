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

        private void btSave_Click(object sender, EventArgs e)
        {
            var context = new HospitalDbContext();
            var myAdress = new Adresses()
            {
                Country = tbCountry.Text,
                District = tbDistrict.Text,
                Region = tbRegion.Text,
                City = tbCity.Text,
                HouseNumber = tbHouseNumber.Text,
                Street = tbStreet.Text,
                Appartment =Convert.ToInt32(tbAppartment.Text)
            };
            
            

            context.Users.Add(new Users()
            {
                FirstName = tbFirstName.Text,

                LastName = tbLastName.Text,
                Birthday = dtpBirthday.Value,
                Passport = tbPassportNunber.Text,
                IdentificationNumber = tbInnNumber.Text,
                IsPatient = true,
                Adress = myAdress,
                Position = context.Positions.First(x=>x.Name=="Undefined"),

                Login = tbLastName.Text +" "+ tbFirstName.Text,
                Password = tbLastName.Text+" "+tbStreet.Text+" "+tbHouseNumber.Text

            });
            context.SaveChanges();
            MessageBox.Show("Patient " + tbFirstName.Text + " " + tbLastName.Text + " was succefully created!", "Information",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
