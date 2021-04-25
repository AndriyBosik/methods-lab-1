using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Component
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [Column("title")]
        public String Title
        { get; set; }

        [Column("price")]
        public Double Price
        { get; set; }

        [Column("type_id")]
        public Int32 TypeId
        { get; set; }

        public virtual ICollection<Value> Values
        { get; set; } = new List<Value>();
    }
}
