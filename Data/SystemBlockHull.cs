using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class SystemBlockHull
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [ForeignKey(nameof(Component))]
        [Column("component_id")]
        public Int32 ComponentId
        { get; set; }

        [Column("width")]
        public Int32 Width
        { get; set; }

        [Column("height")]
        public Int32 Height
        { get; set; }

        [Column("length")]
        public Int32 Length
        { get; set; }
    }
}
