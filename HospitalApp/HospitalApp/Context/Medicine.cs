using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Context
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        //[Index("IndexMedicine", 1, IsUnique = true)]
        public string Name { get; set; }


        //[Index("IndexMedicine",2,IsUnique = true)]
        public Manufacturer Manufacturer { get; set; }

        //[Index("IndexMedicine", 3, IsUnique = true)]
        public MedicineType MedicineType { get;set; }
    }
}
