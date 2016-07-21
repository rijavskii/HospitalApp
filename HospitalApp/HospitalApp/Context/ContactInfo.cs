using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Context
{
    public class ContactInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FkIdUser { get; set; }
       
        public Users IdUser { get; set; }

        public int FkContactType { get; set; }
        
        public ContactType Type { get; set; }

        public string Contact { get; set; }
        public bool Default { get; set; }

    }
}
