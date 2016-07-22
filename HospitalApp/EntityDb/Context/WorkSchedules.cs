using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkSchedules
    {
        
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Users FkDoctor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int WorkRoom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime Data { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [Required]
        public DateTime StartWork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime EndWork { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Users User { get; set; }
    }
}