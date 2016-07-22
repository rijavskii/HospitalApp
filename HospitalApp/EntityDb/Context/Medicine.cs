using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class Medicine : IPrimaryKey
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[Index("IndexMedicine", 1, IsUnique = true)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[Index("IndexMedicine",2,IsUnique = true)]
        public virtual Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //[Index("IndexMedicine", 3, IsUnique = true)]
        public virtual MedicineType MedicineType { get;set; }
    }
}
