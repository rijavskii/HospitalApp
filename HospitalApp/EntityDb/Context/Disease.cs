using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Disease which you have in your card
    /// </summary>
    public class Disease
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Users Patient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DiseaseName { get; set; }

        /// <summary>
        /// How to drop yor disease
        /// </summary>
        public string Treatment { get; set; }
    }
}
