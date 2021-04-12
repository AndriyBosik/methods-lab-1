using System;
using System.Collections.Generic;
using System.Linq;

using Models;
using Models.Interfaces;

using Data;

using DataAccess;
using DataAccess.Specifications;
using DataAccess.Abstraction;

using ApplicationLogic.Interfaces;

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
            ComponentsMapper mapper = new ComponentsMapper();

            IList<Processor> processors = GetComponents(ComponentType.Processor).Select(mapper.ProcessorMapper).ToList();

            RetrieveNeededPower(processors);

            return processors;
        }

        public IList<Motherboard> GetMotherboards()
        {
            ComponentsMapper mapper = new ComponentsMapper();

            IList<Motherboard> motherboards = GetComponents(ComponentType.Motherboard).Select(mapper.MotherboardMapper).ToList();

            RetrieveNeededPower(motherboards);

            return motherboards;
        }

        public IList<MemoryCard> GetMemoryCards()
        {
            ComponentsMapper mapper = new ComponentsMapper();

            IList<MemoryCard> memoryCards = GetComponents(ComponentType.MemoryCard).Select(mapper.MemoryCardMapper).ToList();

            RetrieveNeededPower(memoryCards);

            return memoryCards;
        }

        public IList<PowerSupply> GetPowerSuppliers()
        {
            ComponentsMapper mapper = new ComponentsMapper();

            IList<PowerSupply> powerSuppliers = GetComponents(ComponentType.PowerSupply).Select(mapper.PowerSupplyMapper).ToList();

            RetrieveOtherPowerSuppliersData(powerSuppliers);

            return powerSuppliers;
        }

        public IList<Models.SystemBlockHull> GetSystemBlockHulls()
        {
            ComponentsMapper mapper = new ComponentsMapper();

            IList<Models.SystemBlockHull> systemBlockHulls = GetComponents(ComponentType.SystemBlockHull).Select(mapper.SystemBlockHullMapper).ToList();

            RetrieveOtherSystemBlocksData(systemBlockHulls);

            return systemBlockHulls;

        }

        private void RetrieveOtherSystemBlocksData(IList<Models.SystemBlockHull> systemBlockHulls)
        {
            foreach (Models.SystemBlockHull systemBlockHull in systemBlockHulls)
            {
                Data.SystemBlockHull systemBlock = unitOfWork.SystemBlockHullRepository.ReadByComponentId(systemBlockHull.Id);

                systemBlockHull.AvailablePowerSupplySize = new Tuple<int, int, int>
                    (systemBlock.Width, systemBlock.Height, systemBlock.Length);
            }
        }

        private void RetrieveOtherPowerSuppliersData(IList<PowerSupply> powerSupplies)
        {
            foreach (PowerSupply powerSupply in powerSupplies)
            {
                EnergyProducer energyProducer = unitOfWork.EnergyProducerRepository.ReadByComponentId(powerSupply.Id);

                powerSupply.Size = new Tuple<Int32, Int32, Int32>(energyProducer.Width, energyProducer.Height, energyProducer.Length);
                powerSupply.Power = energyProducer.Power;
            }
        }

        private void RetrieveNeededPower<T>(IList<T> components) where T : SystemComponentBase, IPowerConsumer
        {
            foreach (var component in components)
            {
                EnergyComponent energyComponent = unitOfWork.EnergyComponentRepository.ReadByComponentId(component.Id);
                component.NeededPower = energyComponent.NeededEnergy;
            }
        }

        private IEnumerable<Component> GetComponents(ComponentType componentType)
        {
            return unitOfWork.ComponentRepository.ReadAllByType((Int32) componentType);
        }
    }
}
