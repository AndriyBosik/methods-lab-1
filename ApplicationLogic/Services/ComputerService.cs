using System;
using System.Collections.Generic;
using System.Linq;

using Models;

using Mappers;
using Mappers.Abstraction;

using DataAccess;
using DataAccess.Abstraction;

using ApplicationLogic.Interfaces;
using System.Threading.Tasks;

namespace ApplicationLogic.Services
{
    public class ComputerService: IComputerService
    {
        private IUnitOfWork unitOfWork;

        public ComputerService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<Processor>> GetProcessors()
        {
            return await this.GetComponents(ComponentType.Processor, new ProcessorMapper());
        }

        public async Task<IList<Motherboard>> GetMotherboards()
        {
            return await this.GetComponents(ComponentType.Motherboard, new MotherboardMapper());
        }

        public async Task<IList<MemoryCard>> GetMemoryCards()
        {
            return await this.GetComponents(ComponentType.MemoryCard, new MemoryCardMapper());
        }

        public async Task<IList<PowerSupply>> GetPowerSuppliers()
        {
            return await this.GetComponents(ComponentType.PowerSupply, new PowerSupplyMapper());
        }

        public async Task<IList<Models.SystemBlockHull>> GetSystemBlockHulls()
        {
            return await this.GetComponents(ComponentType.SystemBlockHull, new SystemBlockHullMapper());

        }

        private async Task<IList<T>> GetComponents<T>(ComponentType componentType, IComponentMapper<T> mapper) where T: SystemComponentBase
        {
            return (await unitOfWork.ComponentRepository.ReadAllByType((Int32)componentType)).Select(mapper.Map).ToList();
        }
    }
}
