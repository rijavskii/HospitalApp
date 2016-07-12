using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    class MedicalRegistrar:IEmployee, IAddRecord
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public string StartingOfficeHours { get; set; }
        public string EndOfficeHours { get; set; }
        public string Cellphone { get; set; }

        public void AddRecord() { }
    }
}
