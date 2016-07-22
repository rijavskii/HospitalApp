using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class ContactInfo : IPrimaryKey
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Users User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FkContactType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual ContactType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsDefault { get; set; }

    }
}
