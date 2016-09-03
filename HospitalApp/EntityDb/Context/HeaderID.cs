using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    //ToDo Naming convention
    /// <summary>
    /// 
    /// </summary>
    public class HeaderId
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}