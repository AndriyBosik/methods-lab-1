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

        [Column("title")]
        public String Title
        { get; set; }

        [Column("price")]
        public Double Price
        { get; set; }

        [Column("group")]
        public Int32 Group
        { get; set; }

        public EnergyComponent? EnergyComponent
        { get; set; }

        public EnergyProducer? EnergyProducer
        { get; set; }

        public SystemBlockHull? SystemBlockHull
        { get; set; }
    }
}
