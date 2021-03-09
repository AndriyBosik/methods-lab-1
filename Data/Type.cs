using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Type
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [Column("title")]
        public String Title
        { get; set; }

        [Column("is_multiply")]
        public Boolean IsMultiply
        { get; set; }
    }
}
