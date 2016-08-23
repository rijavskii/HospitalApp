﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Disease which you have in your card
    /// </summary>
    public class Disease: IPrimaryKey
    {
        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

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
