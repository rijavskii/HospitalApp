using System.Collections.Generic;
using EntityDb.Context;
using System;
using HospitalApp.Enum;

namespace HospitalApp
{
    /// <summary>
    /// Class which allow us to export medicine
    /// </summary>
    public class Medicine
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Manufacturer Manufacturer { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public TypeMedicine Type{ get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Medicine> CsvParseMedicines()
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medicine"></param>
        public void PushToDb(List<Medicine> medicine)
        {
            foreach (var value in medicine)
            {
                
            }
        }
    }
}