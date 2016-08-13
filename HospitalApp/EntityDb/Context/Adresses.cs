using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Adress users and patients of hospital
    /// </summary>
    public class Adresses:IPrimaryKey
    {
        
        /// <summary>
        /// Primary key field
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Country where person registered
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// District where person registered
        /// </summary>
        [Required]
        public string District { get; set; }

        /// <summary>
        /// Region where person registered
        /// </summary>
        [Required]
        public string Region { get; set; }

        /// <summary>
        /// City where person registered
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Street where person registered
        /// </summary>
        [Required]
        public string Street { get; set; }

        /// <summary>
        /// House where person registered
        /// </summary>
        [Required]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Appartment of person
        /// </summary>
        [Required]
        public int Appartment { get; set; }

        ///// <summary>
        ///// Person who lives by this adress
        ///// </summary>
        //[Required]
        public Users Users { get; set; }

    }
}