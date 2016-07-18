using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalApp.Context
{
    public class Positions
    {
        //public Positions()
        //{
        //    Id = Guid.NewGuid();
        //}
        //Market this field as primary key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string PositionName { get; set; }

        
    }
}