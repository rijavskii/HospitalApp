using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Include information about medicine
    /// </summary>
    public class Medicine : HeaderId
    {

        /// <summary>
        /// This is a name of drug
        /// </summary>
        [MaxLength(100)]
        [Index("IndexMedicine", 1, IsUnique = true)]
        public string Name { get; set; }

        /// <summary>
        /// Who makes such drugs
        /// </summary>
        [MaxLength(100)]
        [Index("IndexMedicine",2,IsUnique = true)]
        public virtual Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// What kind of drugs this is
        /// </summary>
        [MaxLength(100)]
        [Index("IndexMedicine", 3, IsUnique = true)]
        public virtual MedicineType MedicineType { get; set; }
    }
}
