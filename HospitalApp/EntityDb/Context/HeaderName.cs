using System.ComponentModel.DataAnnotations;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class HeaderName : HeaderId
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}