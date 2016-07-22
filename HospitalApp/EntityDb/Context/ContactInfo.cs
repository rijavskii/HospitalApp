using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// If you want to contact with person look here
    /// </summary>
    public class ContactInfo : IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User you want to contact
        /// </summary>
        public virtual Users User { get; set; }

        /// <summary>
        /// Type of contact information
        /// </summary>
        public virtual ContactType Type { get; set; }

        /// <summary>
        /// Contact data of person
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// Default contact data
        /// </summary>
        public bool IsDefault { get; set; }

    }
}
