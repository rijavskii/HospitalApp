using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class Users
    {
        /// <summary>
        /// 
        /// </summary>
        //Market this field as primary key
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MinLength(3, ErrorMessage = "Length must be more that 3 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MinLength(3, ErrorMessage = "Length must be more that 5 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public bool IsPatient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Passport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int IdentificationNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int Adress { get; set; }

        //Foreign key
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Positions Positions { get; set; }
    }
}