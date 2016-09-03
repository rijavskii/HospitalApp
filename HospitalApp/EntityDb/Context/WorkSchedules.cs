using System;
using System.ComponentModel.DataAnnotations;

namespace EntityDb.Context
{
    /// <summary>
    /// When the worker work
    /// </summary>
    public class WorkSchedules:HeaderId
    {
        /// <summary>
        /// Who this person is
        /// </summary>
        [Required]
        public Users FkWorker { get; set; }

        /// <summary>
        /// Where I should look for him
        /// </summary>
        [Required]
        public int WorkRoom { get; set; }

        /// <summary>
        /// Date when he work
        /// </summary>
        [Required]
        public DateTime Data { get; set; }
    }
}