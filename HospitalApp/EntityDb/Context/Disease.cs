using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class Disease
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IdPatient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DiseaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Treatment { get; set; }
    }
}
