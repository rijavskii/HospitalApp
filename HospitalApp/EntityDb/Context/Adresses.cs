using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Adresses of users of hospital
    /// </summary>
    public class Adresses:IPrimaryKey
    {
        //Marked this field as primary key
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Coyntry where person live
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string District { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Street { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string HouseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int Appartment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public virtual Users Users { get; set; }

    }
}