using System;
using System.Collections.Generic;
using System.Text;

using Models;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;

namespace ApplicationLogic
{
    public class ComponentsHolder: IComponentsHolder
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

        public ComponentsHolder()
        {
            IComputerService service = new ComputerService();
            MemoryCards = service.GetMemoryCards();
            Motherboards = service.GetMotherboards();
            PowerSuppliers = service.GetPowerSuppliers();
            Processors = service.GetProcessors();
            SystemBlockHulls = service.GetSystemBlockHulls();
        }
    }
}
