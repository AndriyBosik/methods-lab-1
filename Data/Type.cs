using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Type
    {
        [Key]
        [Column("group")]
        public Int32 Group
        { get; set; }

        [Column("is_multiply")]
        public Boolean IsMultiply
        { get; set; }
    }
}
