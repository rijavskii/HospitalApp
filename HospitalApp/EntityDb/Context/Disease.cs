using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Disease which you have in your card
    /// </summary>
    public class Disease: HeaderName
    {
        /// <summary>
        /// Who has this disease 
        /// </summary>
        public Users Patient { get; set; }

        /// <summary>
        /// The best way to drop yor disease
        /// </summary>
        public string Treatment { get; set; }

        
    }
}
