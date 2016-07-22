using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace EntityDb.Context
{
    /// <summary>
    /// Interface with primary key attribute
    /// </summary>
    public interface IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }
    }
}