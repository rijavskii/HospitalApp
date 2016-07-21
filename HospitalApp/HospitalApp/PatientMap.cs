using System.Collections.Generic;
using HospitalApp.Context;

namespace HospitalApp
{
    public class PatientMap:Patient
    {
        private List<Record> Records { get; set; }
    }
}