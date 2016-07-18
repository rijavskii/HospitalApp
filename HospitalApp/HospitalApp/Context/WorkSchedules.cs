using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalApp.Context
{
    public class WorkSchedules
    {
        
        //Market this field as primary key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int IdDoctor { get; set; }

        [Required]
        public int WorkRoom { get; set; }

        [Required]
        public DateTime StartWork { get; set; }

        [Required]
        public DateTime EndWork { get; set; }

        //Foreign key to user
        public Users User { get; set; }
    }
}