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

        public async Task<IList<Processor>> GetProcessorsAsync()
        {
            return await this.GetComponentsAsync(ComponentType.Processor, new ProcessorMapper());
        }

        public async Task<IList<Motherboard>> GetMotherboardsAsync()
        {
            return await this.GetComponentsAsync(ComponentType.Motherboard, new MotherboardMapper());
        }

        public async Task<IList<MemoryCard>> GetMemoryCardsAsync()
        {
            return await this.GetComponentsAsync(ComponentType.MemoryCard, new MemoryCardMapper());
        }

        public async Task<IList<PowerSupply>> GetPowerSuppliersAsync()
        {
            return await this.GetComponentsAsync(ComponentType.PowerSupply, new PowerSupplyMapper());
        }

        public async Task<IList<Models.SystemBlockHull>> GetSystemBlockHullsAsync()
        {
            return await this.GetComponentsAsync(ComponentType.SystemBlockHull, new SystemBlockHullMapper());

        }

        private async Task<IList<T>> GetComponentsAsync<T>(ComponentType componentType, IComponentMapper<T> mapper) where T: SystemComponentBase
        {
            return (await unitOfWork.ComponentRepository.ReadAllByTypeAsync((Int32)componentType)).Select(mapper.Map).ToList();
        }
    }
}
