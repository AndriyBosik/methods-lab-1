using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;

using Models;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class ComponentsHolder: IComponentsHolder
    {
        private IComputerService service;

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

        

        public ComponentsHolder(IComputerService service)
        {
            this.service = service;

            GetComponents();
        }

        private async void GetComponents()
        {
            MemoryCards = await service.GetMemoryCardsAsync();
            Motherboards = await service.GetMotherboardsAsync();
            PowerSuppliers = await service.GetPowerSuppliersAsync();
            Processors = await service.GetProcessorsAsync();
            SystemBlockHulls = await service.GetSystemBlockHullsAsync();
        }
    }
}
