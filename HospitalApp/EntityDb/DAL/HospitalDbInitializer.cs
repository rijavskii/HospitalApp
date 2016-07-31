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

            defaultPositions.Add(new Positions() { PositionName = "Undefined" });
            defaultPositions.Add(new Positions() { PositionName = "Doctor" });
            defaultPositions.Add(new Positions() { PositionName = "Nurse" });

            //defaultUsers.Add(new Users()
            //{
            //    FirstName = "Vitia",
            //    LastName = "Petrov",
            //    IsPatient = false,
            //    IdentificationNumber = 12457889,
            //    Position = defaultPositions.ElementAt(2)
            //});

            //foreach (var value in defaultUsers)
            //{
            //    context.Users.Add(value);
            //}
            
            foreach (var value in defaultPositions)
            {
                context.Positions.Add(value);
            }
            base.Seed(context);

            
            
            //defaulTypeMedicines.Add(new TypeMedicines() {});
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