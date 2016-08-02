

using EntityDb.Context;
using System;
using System.Collections.Generic;
using System.IO;

namespace HospitalApp
{
    /// <summary>
    /// Class which allow us to export medicine
    /// </summary>
    public class Medicine
    {
        public string Name { get; set; }
        //public Manufacturer Manufact { get; set; }
        //public MedicineType Type { get; set; }
        public string FactoryName { get; set; }
        public string FactoryCountry { get; set; }
        public string TypeName { get; set; }

        public override string ToString()
        {
            //return string.Format("{0}, {1}, {2}, {3}, {4}", Name, Manufact.FactoryName, Manufact.Country, Type.Name, Environment.NewLine);
            return string.Format("{0}, {1}, {2}, {3}, {4}", Name, FactoryName, FactoryCountry, TypeName, Environment.NewLine);
        }
       
    }
}