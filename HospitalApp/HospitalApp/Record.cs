using System;
using System.Collections.Generic;

namespace HospitalApp
{
    public class Record
    {
        public uint Doctor { get; set; }
        public List<Disease> Diseases { get; set; }
        public List<Medicine> Medicines { get; set; }
        public DateTime RecordData { get; set; }
        public DateTime DischargeData { get; set; }
        public string AdditionalInfo { get; set; }
        
    }
}