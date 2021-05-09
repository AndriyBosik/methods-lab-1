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

            Task.Run(() => GetComponents()).Wait();
        }

        private async Task GetComponents()
        {
            await Task.WhenAll(
                new List<Task>()
                {
                    Task.Run(async () => { MemoryCards = await service.GetMemoryCards(); }),
                    Task.Run(async () => { Motherboards = await service.GetMotherboards(); }),
                    Task.Run(async () => { PowerSuppliers = await service.GetPowerSuppliers(); }),
                    Task.Run(async () => { Processors = await service.GetProcessors(); }),
                    Task.Run(async () => { SystemBlockHulls = await service.GetSystemBlockHulls(); }),
                }
            );
        }
    }
}
