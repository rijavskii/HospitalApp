using System;
using System.Data.Entity;
using EntityDb.Context;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using HospitalApp;

namespace EntityDb.DAL
{
    /// <summary>
    /// Initialize our Database
    /// </summary>
    public class HospitalDbInitializer : CreateDatabaseIfNotExists<HospitalDbContext> //this base class used only when db created
    {

        /// <summary>
        /// Set our database with default values
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(HospitalDbContext context)
        {
            try
            {
                context.Positions.Add(new Positions() { Name = "none", PositionCode = 1});
                context.Positions.Add(new Positions() { Name = "doctor", PositionCode = 4});
                context.Positions.Add(new Positions() { Name = "nurse", PositionCode = 5});
                context.Positions.Add(new Positions() { Name = "admin", PositionCode = 2});
                context.Positions.Add(new Positions() { Name = "registry", PositionCode = 3});
           
                context.Adresses.Add(new Adresses()
                {
                    City = "admin",
                    Region = "admin",
                    Street = "admin",
                    Appartment = 15,
                    District = "admin",
                    HouseNumber = "admin1",
                    Country = "Ukraine",
                    //Users = context.Users.First(x=>x.Login == "admin")

                });
            //base.Seed(context);
                context.SaveChanges();
            
                context.Users.Add(new Users
                {
                    FirstName = "admin",
                    MiddleName = "admin",
                    LastName = "admin",
                    Birthday = DateTime.Today,
                    Login = "admin",
                    Password = "admin".GetMd5Hash(),
                    Passport = "admin",
                    IdentificationNumber = "admin",
                    Adress = context.Adresses.Find(1),
                    Position = context.Positions.Find(4),
                });
                base.Seed(context);
            }
            catch (DbUpdateException a)
            {
                foreach (var eve in a.Entries)
                {
                    MessageBox.Show("Entity of type \"" + eve.Entity.GetType() +
                                    "\" in state \"" + eve.GetValidationResult() + "\" has the following validation errors:",
                        "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //foreach (var ve in eve.ValidationErrors)
                    //{
                    //    MessageBox.Show("- Property: \"" + ve.PropertyName + "\", Error: \"" + ve.ErrorMessage + "\"",
                    //        "Information",
                    //        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                    //        ve.PropertyName, ve.ErrorMessage);
                    //}
                }
                throw;
            }
            
            
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
            //defaulTypeMedicines.Add(new TypeMedicines() { });
        }
    }
}