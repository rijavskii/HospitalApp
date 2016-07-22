using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPrimaryKey
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        int Id { get; set; } 
    }
}