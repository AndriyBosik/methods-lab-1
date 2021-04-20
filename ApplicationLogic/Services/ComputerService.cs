using System;
using System.Collections.Generic;
using System.Linq;

using Models;
using Models.Interfaces;

using Mappers;

using Data;

using DataAccess;
using DataAccess.Abstraction;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Factories;

namespace ApplicationLogic.Services
{
    public class ComputerService: IComputerService
    {
        private IUnitOfWork unitOfWork;

        public ComputerService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public IList<Processor> GetProcessors()
        {
            return this.GetComponents(ComponentType.Processor, new ProcessorMapper());
        }

        public IList<Motherboard> GetMotherboards()
        {
            return this.GetComponents(ComponentType.Motherboard, new MotherboardMapper());
        }

        public IList<MemoryCard> GetMemoryCards()
        {
            return this.GetComponents(ComponentType.MemoryCard, new MemoryCardMapper());
        }

        public IList<PowerSupply> GetPowerSuppliers()
        {
            return this.GetComponents(ComponentType.PowerSupply, new PowerSupplyMapper());
        }

        public IList<Models.SystemBlockHull> GetSystemBlockHulls()
        {
            return this.GetComponents(ComponentType.SystemBlockHull, new SystemBlockHullMapper());

        }

        private IList<T> GetComponents<T>(ComponentType componentType, IComponentMapper<T> mapper) where T: SystemComponentBase
        {
            return unitOfWork.ComponentRepository.ReadAllByType((Int32)componentType).Select(mapper.Map).ToList();
        }
    }
}
