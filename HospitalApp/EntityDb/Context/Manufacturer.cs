using System.ComponentModel.DataAnnotations;

namespace EntityDb.Context
{
    /// <summary>
    /// Who makes drugs
    /// </summary>
    public class Manufacturer : IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Who produce such a good medicine
        /// </summary>
        //[Index("IndexManufacturer",1, IsUnique = true)]
        [Required]
        public string FactoryName { get; set; }

        /// <summary>
        /// Where manufacturer located
        /// </summary>
        //[Index("IndexManufacturer", 2, IsUnique = true)]
        [Required]
        public string Country { get; set; }


    }
}
