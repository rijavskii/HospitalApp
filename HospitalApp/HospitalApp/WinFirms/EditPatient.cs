using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityDb.Context;
using EntityDb.DAL;

namespace HospitalApp
{
    /// <summary>
    /// Class for changing patient information
    /// </summary>
    public partial class EditPatient : Form
    {
        //ToDo remove this *details see at CoreForm.cs
        private Users _myUser = null;
        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="user">Patient to update</param>
        public EditPatient(Users user)
        {
            InitializeComponent();
            _myUser = user;

            SetDefault(user);
            
        }

        /// <summary>
        /// Set patient data into textboxes
        /// </summary>
        /// <param name="user"></param>
        private void SetDefault(Users user)
        {
            tbFirstName.Text = user.FirstName;
            tbMiddleName.Text=user.MiddleName;
            tbLastName.Text = user.LastName;
            dtpBirthday.Text = user.Birthday.ToShortDateString();
            //var pass = user.Passport.Substring(1,3);
            tbLogin.Text = user.Login;

            //mtbPassportSeries.Text = user.Passport.Substring(1,3);
            mtbPassportNumber.Text = user.Passport.Substring(2);
            mtbInnNumber.Text = user.IdentificationNumber;

            tbCountry.Text = user.Adress.Country;
            tbDistrict.Text = user.Adress.District;
            tbRegion.Text = user.Adress.Region;
            tbCity.Text = user.Adress.City;
            tbHouseNumber.Text = user.Adress.HouseNumber;
            tbStreet.Text = user.Adress.Street;
            tbAppartment.Text = user.Adress.Appartment.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            using (var context = new HospitalDbContext())
            {
                _myUser = context.Users.SingleOrDefaultAsync(x => x.Id == _myUser.Id).Result;
           
                if (_myUser != null)
                {
                    _myUser.FirstName = tbFirstName.Text;
                    _myUser.MiddleName = tbMiddleName.Text;
                    _myUser.LastName = tbLastName.Text;
                    _myUser.Birthday = dtpBirthday.Value;
                    _myUser.Login = tbLogin.Text;

                    if (String.IsNullOrWhiteSpace(tbPassword.Text.Trim()))
                    {
                        _myUser.Password = tbPassword.Text.GetMd5Hash();
                    }

                    _myUser.Passport = mtbPassportSeries.Text.Trim() + mtbPassportNumber.Text.Trim();
                    _myUser.IdentificationNumber = mtbInnNumber.Text.Trim();
                    _myUser.Position = context.Positions.SingleOrDefault(x => x.Id == _myUser.Position.Id);
                    _myUser.Adress.Country = tbCountry.Text;
                    _myUser.Adress.Region = tbRegion.Text;
                    _myUser.Adress.District = tbDistrict.Text;
                    _myUser.Adress.City = tbCity.Text;
                    _myUser.Adress.Street = tbStreet.Text;
                    _myUser.Adress.HouseNumber = tbHouseNumber.Text;

                    _myUser.Adress.Appartment = Convert.ToInt32(tbAppartment.Text);
                //using (var context = new HospitalDbContext())
                //    {
                        context.Users.AddOrUpdate(_myUser);
                        context.SaveChanges();

                        //try
                        //{
                        //    // Your code...
                        //    // Could also be before try if you know the exception occurs in SaveChanges

                        //    context.SaveChanges();
                        //}
                        //catch (DbEntityValidationException a)
                        //{
                        //    foreach (var eve in a.EntityValidationErrors)
                        //    {
                        //        Console.WriteLine(
                        //            "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        //        foreach (var ve in eve.ValidationErrors)
                        //        {
                        //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                        //                ve.PropertyName, ve.ErrorMessage);
                        //        }
                        //    }
                        //    throw;
                        //}
                }
            }
        }
    }
}
