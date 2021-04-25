using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Value
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [ForeignKey(nameof(Component))]
        [Column("component_id")]
        public Int32 ComponentId
        { get; set; }

        [ForeignKey("Attribute")]
        [Column("attribute_id")]
        public Int32 AttributeId
        { get; set; }

        [Column("data")]
        public String Data
        { get; set; }

        public virtual Attribute Attribute
        { get; set; }
    }
}
