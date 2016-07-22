using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HospitalApp.Context;

namespace EntityDb.Context
{
    public class Adresses:IPrimaryKey
    {
        //Marked this field as primary key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        
        public int Appartment { get; set; }

        public int IdUser { get; set; }

        public Users Users { get; set; }

    }
}