using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            ICollection<Users> defaultUsers = new List<Users>();
            ICollection<Positions> defaultPositions = new List<Positions>();

            context.Positions.Add(new Positions() { PositionName = "Undefined" });
            defaultPositions.Add(new Positions() { PositionName = "Doctor" });
            defaultPositions.Add(new Positions() { PositionName = "Nurse" });


            
            
            foreach (var value in defaultPositions)
            {
                context.Positions.Add(value);
            }

            context.Users.Add(new Users
            {
                Position = context.Positions.First(x => x.Id == 2),
                FirstName = "FirstName"
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