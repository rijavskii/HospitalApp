using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Drug types
    /// </summary>
    public class MedicineType : IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of drug type
        /// </summary>
        public string Name { get; set; }
    }

}
