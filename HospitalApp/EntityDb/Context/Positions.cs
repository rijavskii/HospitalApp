﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDb.Context
{
    /// <summary>
    /// Information about positions types in hospital
    /// </summary>
    public class Positions : IPrimaryKey
    {
        //public Positions()
        //{
        //    Id = Guid.NewGuid();
        //}
        //Market this field as primary key

        /// <summary>
        /// Primary key field of table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Position name of hospital worker
        /// </summary>
        [Required]
        public string PositionName { get; set; }

        
    }
}