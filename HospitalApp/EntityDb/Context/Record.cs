using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Records whith which patient card consists
    /// </summary>
    public class Record : HeaderID
    {
        /// <summary>
        /// Creates list of patient diseases and medicines
        /// </summary>
        public Record ()
        {
            Disease = new List<Disease>();
            Medicine = new List<Medicine>();
        }

        /// <summary>
        /// Who are treatingor treated you
        /// </summary>
        public Users Doctor { get; set; }

        /// <summary>
        /// Who are you(patient)
        /// </summary>
        public Users Patient { get; set; }
        
        /// <summary>
        /// When record was made
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// When you go out from hosptall with happy face
        /// </summary>
        public DateTime DischargeDate { get; set; }

        /// <summary>
        /// Additional information to the record
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// List of patient diseases if he has such ones
        /// </summary>
        public virtual ICollection<Disease> Disease { get; set; }

        /// <summary>
        /// What medicines need to make you happy
        /// </summary>
        public virtual ICollection<Medicine> Medicine { get; set; }
    }
}
