using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Information about positions types in hospital
    /// </summary>
    public class Positions : HeaderName
    {
        ///// <summary>
        ///// Primary key field of table
        ///// </summary>
        //public new int Id { get; set; }

        ///// <summary>
        ///// Position name of hospital worker
        ///// </summary>
        //[Required]
        //public string Name { get; set; }

        /// <summary>
        /// Unique code for concrete position
        /// </summary>
        public int PositionCode { get; set; }

        /// <summary>
        /// Type of current worker position
        /// </summary>
        public virtual PositionType WorkerPositionType { get; set; }
    }
}