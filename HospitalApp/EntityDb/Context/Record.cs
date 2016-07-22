using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class Record
    {
        public Record ()
        {
            Disease = new List<Disease>();
            Medicine = new List<Medicine>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IdDoctor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IdPatient { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DischargeDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FkDisease { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Disease> Disease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FkMedicine { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Medicine> Medicine { get; set; }
    }
}
