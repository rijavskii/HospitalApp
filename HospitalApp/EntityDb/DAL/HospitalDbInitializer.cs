using System.Collections.Generic;
using System.Data.Entity;
using EntityDb.Context;

namespace EntityDb.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class HospitalDbInitializer : CreateDatabaseIfNotExists<HospitalDbContext> //this base class used only when db created
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(HospitalDbContext context)
        {
            ICollection<Positions> defaultPositions = new List<Positions>();

            defaultPositions.Add(new Positions() { PositionName = "Undefined" });
            defaultPositions.Add(new Positions() { PositionName = "Doctor"});
            defaultPositions.Add(new Positions() { PositionName = "Nurse" });

            foreach (var value in defaultPositions)
            {
                context.Positions.Add(value);
            }
            base.Seed(context);
            //List<TypeMedicines> defaulTypeMedicines = new List<TypeMedicines>();

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