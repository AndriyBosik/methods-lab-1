using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class SystemBlockComponent
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [ForeignKey(nameof(Component))]
        [Column("component_id")]
        public Int32 ComponentId
        { get; set; }

        [ForeignKey(nameof(SystemBlock))]
        [Column("system_block_id")]
        public Int32 SystemBlockId
        { get; set; }
    }
}
