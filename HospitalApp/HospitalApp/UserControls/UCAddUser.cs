﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp.UserControls
{
    public partial class UcAddUser : UserControl
    {
        public UcAddUser()
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

            if (tbFirstName.Text.Trim().Length < 3)
            {
                tbFirstName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbFirstName.BackColor = Color.White;
            }

            if (tbMiddleName.Text.Trim().Length < 3)
            {
                tbMiddleName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbMiddleName.BackColor = Color.White;
            }

            if (tbLastName.Text.Trim().Length < 3)
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

            if (String.IsNullOrWhiteSpace(tbCountry.Text.Trim()))
            {
                tbCountry.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbCountry.BackColor = Color.White;
            }

            if (String.IsNullOrWhiteSpace(tbRegion.Text.Trim()))
            {
                tbRegion.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbRegion.BackColor = Color.White;
            }

            if (String.IsNullOrWhiteSpace(tbDistrict.Text.Trim()))
            {
                tbDistrict.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbDistrict.BackColor = Color.White;
            }

            if (String.IsNullOrWhiteSpace(tbCity.Text.Trim()))
            {
                tbCity.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbCity.BackColor = Color.White;
            }

            if (String.IsNullOrWhiteSpace(tbStreet.Text.Trim()))
            {
                tbStreet.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbStreet.BackColor = Color.White;
            }

            if (String.IsNullOrWhiteSpace(tbHouseNumber.Text.Trim()))
            {
                tbHouseNumber.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                tbHouseNumber.BackColor = Color.White;
            }

            if (String.IsNullOrWhiteSpace(tbAppartment.Text.Trim()))
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
                Adresses myAdress;
                string passport = (mtbPassportSeries.Text + mtbPassportNumber.Text).Trim();
                using (var context = new HospitalDbContext())
                {
                    
                    myAdress = context.Adresses.Add(new Adresses()
                    {
                        Country = tbCountry.Text,
                        District = tbDistrict.Text,
                        Region = tbRegion.Text,
                        City = tbCity.Text,
                        HouseNumber = tbHouseNumber.Text,
                        Street = tbStreet.Text,
                        Appartment = Convert.ToInt32(tbAppartment.Text)
                    });
                    context.SaveChanges();
                
                    //string login = String.Format("{0} {1}", tbLastName.Text, tbFirstName.Text);
                    string login = $"{tbLastName.Text}{tbFirstName.Text}{dtpBirthday.Value.Year}";
                    
                    //string psd = String.Format("{0} {1} {2}",tbLastName.Text, tbStreet.Text, tbHouseNumber.Text);
                    string psd = $"{tbLastName.Text}{tbStreet.Text}{tbHouseNumber.Text}";
                    context.Users.Add(new Users()
                    {
                        FirstName = tbFirstName.Text,
                        MiddleName = tbMiddleName.Text,
                        LastName = tbLastName.Text,
                        Birthday = dtpBirthday.Value,
                        Passport = passport,
                        IdentificationNumber = mtbInnNumber.Text,
                        IsPatient = true,
                        Adress = context.Adresses.FirstOrDefault(x=>x.Id == myAdress.Id),
                        Position = context.Positions.FirstOrDefault(x => x.Name == "Undefined"),

                        Login = login,
                        Password = psd.GetMd5Hash()

                    });

                    //context.SaveChanges();
                    try
                    {
                        // Your code...
                        // Could also be before try if you know the exception occurs in SaveChanges

                        context.SaveChanges();
                    }
                    catch (DbEntityValidationException a)
                    {
                        ShowErrors(a);
                        throw;
                    }

                    MessageBox.Show("Patient " + tbFirstName.Text + " " + tbLastName.Text + " was succefully created!" +
                                    Environment.NewLine + "Login: " + "\"" + login + "\""+Environment.NewLine +
                                    "Password: " + "\"" + psd + "\"",
                        "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ShowErrors(DbEntityValidationException a)
        {
            foreach (var eve in a.EntityValidationErrors)
            {
                MessageBox.Show("Entity of type \"" + eve.Entry.Entity.GetType().Name +
                                "\" in state \"" + eve.Entry.State + "\" has the following validation errors:",
                    "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var ve in eve.ValidationErrors)
                {
                    MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Error: \"" + ve.ErrorMessage + "\"",
                        "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                        ve.PropertyName, ve.ErrorMessage);
                }
            }
        }

        private void tbAppartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if ((Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Delete )
                    e.Handled = true;
        }
    }
}
