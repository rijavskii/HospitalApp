using System.ComponentModel.DataAnnotations;

namespace EntityDb.Context
{
    public class HeaderName:HeaderID
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}