using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class EnergyComponent
    {
        [Key]
        [Column("id")]
        public Int32 Id
        { get; set; }

        [ForeignKey(nameof(Component))]
        [Column("component_id")]
        public Int32 ComponentId
        { get; set; }

        [Column("needed_energy")]
        public Int32 NeededEnergy
        { get; set; }
    }
}
