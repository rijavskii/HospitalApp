using System.Collections.Generic;
using System.Data.Entity;
using HospitalApp.Context;

namespace HospitalApp.DAL
{
    public class HospitalDbInitializer : CreateDatabaseIfNotExists<HospitalDbContext> //this base class used only when db created
    {
        protected override void Seed(HospitalDbContext context)
        {
            List<Positions> defaultPositions = new List<Positions>();

            defaultPositions.Add(new Positions() { PositionName = "Undefined" });
            defaultPositions.Add(new Positions() { PositionName = "Doctor"});
            defaultPositions.Add(new Positions() { PositionName = "Nurse" });

            List<TypeMedicines> defaulTypeMedicines = new List<TypeMedicines>();

            defaulTypeMedicines.Add(new TypeMedicines() {});
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
            defaulTypeMedicines.Add(new TypeMedicines() { });
        }
    }
}