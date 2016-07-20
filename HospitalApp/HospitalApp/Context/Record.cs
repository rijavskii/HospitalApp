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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdDoctor { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("FK_Disease")]
        public ICollection<Disease> Disease { get; set; }
        [ForeignKey("FK_Medicine")]
        public ICollection<Medicine> Medicine { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
