using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class Manufacturer : IPrimaryKey
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[Index("IndexManufacturer",1, IsUnique = true)]
        public string FactoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[Index("IndexManufacturer", 2, IsUnique = true)]
        public string Country { get; set; }


    }
}
