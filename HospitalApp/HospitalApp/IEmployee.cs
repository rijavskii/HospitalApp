using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        string Position { get; set; }
        string StartingOfficeHours { get; set; }
        string EndOfficeHours { get; set; }
        string Cellphone { get; set; }
    }
}
