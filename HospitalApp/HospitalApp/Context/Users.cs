using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace HospitalApp.Context
{
    public class Users
    {
        //Market this field as primary key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Length must be more that 3 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3, ErrorMessage = "Length must be more that 5 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string LastName { get; set; }

        [DefaultValue(false)]
        public bool Patient { get; set; }

        [Required]
        public string Passport { get; set; }

        [Required]
        public int IdentificationNumber { get; set; }

        [Required]
        public int Adress { get; set; }

        //Foreign key
        [Required]

        // public int Position { get; set; }
        // [ForeignKey("Position")]
        public Positions Positions { get; set; }
    }
}