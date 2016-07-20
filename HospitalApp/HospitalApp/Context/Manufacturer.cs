using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Context
{
    public class Manufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Index("IndexManufacturer",1, IsUnique = true)]
        public string FactoryName { get; set; }
        [Index("IndexManufacturer", 2, IsUnique = true)]
        public string Country { get; set; }


    }
}
