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

        [ForeignKey("FK_IdUser")]
        public Users IdUser { get; set; }
        [ForeignKey("FK_ContactType")]
        public ContactType Type { get; set; }
        public string Contact { get; set; }
        public bool Default { get; set; }


    }
}
