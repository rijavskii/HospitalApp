using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Context
{
    public class Record
    {
        public Record ()
        {
            Disease = new List<Disease>();
            Medicine = new List<Medicine>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdDoctor { get; set; }
        public int IdPatient { get; set; }
        
        public DateTime RecordDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string AdditionalInfo { get; set; }

        public int FkDisease { get; set; }
        
        public virtual ICollection<Disease> Disease { get; set; }

        public int FkMedicine { get; set; }
        
        public virtual ICollection<Medicine> Medicine { get; set; }
    }
}
