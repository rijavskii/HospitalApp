﻿using System;
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
            context.Positions.Add(new Positions() { Name = "Undefined" });
            context.Positions.Add(new Positions() { Name = "Doctor" });
            context.Positions.Add(new Positions() { Name = "Nurse" });
            context.Positions.Add(new Positions() { Name = "Admin"});
            context.Positions.Add(new Positions() { Name = "Registry" });

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
                Password = "admin",
                Passport = "admin",
                IdentificationNumber = "admin",
                Adress = context.Adresses.First(x=>x.City=="admin"),
                Position = context.Positions.First(x => x.Name == "Admin")
                
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