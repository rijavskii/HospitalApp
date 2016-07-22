using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Card where should be written all diseases of patient
    /// </summary>
    public class CardPatient:IPrimaryKey
    {
        /// <summary>
        /// Constructor which create list of patient records in hospital
        /// </summary>
        public CardPatient()
        {
            Record = new List<Record>();
        }

        /// <summary>
        /// Id for patient card
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// List with records in patient card
        /// </summary>
        public virtual ICollection<Record> Record { get; set; }
    }
}
