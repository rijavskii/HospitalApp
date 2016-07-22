using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class CardPatient:IPrimaryKey
    {
        /// <summary>
        /// 
        /// </summary>
        public CardPatient()
        {
            
            Record = new List<Record>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Record> Record { get; set; }
    }
}
