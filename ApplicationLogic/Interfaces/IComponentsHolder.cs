using System;
using System.Collections.Generic;
using System.Text;

using Models;

namespace ApplicationLogic.Interfaces
{
    public interface IComponentsHolder
    {
        public IList<MemoryCard> MemoryCards
        { get; set; }

        public IList<Motherboard> Motherboards
        { get; set; }

        public IList<PowerSupply> PowerSuppliers
        { get; set; }

        public IList<Processor> Processors
        { get; set; }

        public IList<SystemBlockHull> SystemBlockHulls
        { get; set; }
    }
}
