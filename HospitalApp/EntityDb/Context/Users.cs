using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Informations about people which have relation to hospital
    /// </summary>
    public class Users:IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User First Name(How do I call you)
        /// </summary>
        [MinLength(3, ErrorMessage = "Length must be more that 3 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// User Last Name(How do I call you v2)
        /// </summary>
        [MinLength(3, ErrorMessage = "Length must be more that 5 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Name to access to your acount
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// Key to access to your acount
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Are you a patient?
        /// </summary>
        [DefaultValue(false)]
        public bool IsPatient { get; set; }

        /// <summary>
        /// Passport code and number
        /// </summary>
        [Required]
        public string Passport { get; set; }

        /// <summary>
        /// Your identification number
        /// </summary>
        [Required]
        public int IdentificationNumber { get; set; }

        /// <summary>
        /// Where I should look user
        /// </summary>
        [Required]
        public Adresses Adress { get; set; }

        //Foreign key
        /// <summary>
        /// Whom the person works
        /// </summary>
        [Required]
        public Positions Position { get; set; }
    }
}