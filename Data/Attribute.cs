﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Attribute
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [Column("title")]
        public String Title
        { get; set; }
    }
}
