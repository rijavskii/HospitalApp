using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Context
{
    public class CardPatient
    {
        public CardPatient()
        {
            IdRecord = new List<Record>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FkUserRecords { get; set; }
        
        //TODO virtual to all classes
        public virtual ICollection<Record> IdRecord { get; set; }
    }
}
