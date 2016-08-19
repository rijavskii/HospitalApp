using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Type of concrete contact info 
    /// </summary>
    public class ContactType : IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of contact type (phone, fax, email, etc.)
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
