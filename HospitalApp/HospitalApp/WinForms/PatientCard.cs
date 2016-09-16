using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    public partial class PatientCard : Form
    {
        private readonly int _patient;
        public PatientCard(int userId)
        {
            if (userId != 0)
            {
                InitializeComponent();
                _patient = userId;
            }
            else
                MessageBox.Show(@"Patient not exist!!!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PatientCard_Load(object sender, EventArgs e)
        {
            using (var context  = new HospitalDbContext())
            {
                var user = context.Users.Include(x => x.Adress).FirstOrDefault(x => x.Id == _patient);

                if (user == null) return;

                FillFields(user);
            }
        }

        private void FillFields(Users me)
        {
            var adress = $"{me.Adress.Country}, {me.Adress.Region}, {me.Adress.District}, " +
                         $"{me.Adress.City}, {me.Adress.Street}, {me.Adress.HouseNumber}";
            tbFirstName.Text = me.FirstName;
            tbMiddleName.Text = me.MiddleName;
            tbLastName.Text = me.LastName;

            dtpBirthday.Value = me.Birthday;
            tbPassport.Text = me.Passport;
            mtbInnNumber.Text = me.IdentificationNumber;
            tbAddress.Text = adress;

        }
    }
}
