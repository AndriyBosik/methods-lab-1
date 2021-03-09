using System;
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

        [ForeignKey(nameof(Type))]
        [Column("type_id")]
        public Int32 TypeID
        { get; set; }

        [Column("title")]
        public String Title
        { get; set; }

        [Column("price")]
        public Double Price
        { get; set; }
    }
}
