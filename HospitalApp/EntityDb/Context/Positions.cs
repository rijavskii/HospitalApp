using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class Positions : IPrimaryKey
    {
        //public Positions()
        //{
        //    Id = Guid.NewGuid();
        //}
        //Market this field as primary key
        
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string PositionName { get; set; }

        
    }
}