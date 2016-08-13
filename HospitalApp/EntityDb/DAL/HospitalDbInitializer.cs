using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using EntityDb.Context;

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
            context.Positions.Add(new Positions() { PositionName = "Undefined" });
            context.Positions.Add(new Positions() { PositionName = "Doctor" });
            context.Positions.Add(new Positions() { PositionName = "Nurse" });
            context.Positions.Add(new Positions() { PositionName = "Admin"});

            context.Adresses.Add(new Adresses()
            {
                City = "admin",
                Region = "admin",
                Street = "admin",
                Appartment = 15,
                District = "admin",
                HouseNumber = "admin1",
                Country = "Ukraine",

            });
            //base.Seed(context);
            context.SaveChanges();
            context.Users.Add(new Users
            {
                FirstName = "admin",
                LastName = "admin",
                Login = "admin",
                Password = "admin",
                Passport = "admin",
                IdentificationNumber = 0,
                Adress = context.Adresses.First(x=>x.City=="admin"),
                Position = context.Positions.First(x => x.PositionName == "Admin")
                
            });

            base.Seed(context);
            
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