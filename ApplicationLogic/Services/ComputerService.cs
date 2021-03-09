using System;
using System.Collections.Generic;
using System.Linq;

using Models;
using Models.Interfaces;

using Data;

using DataAccess;
using DataAccess.Specifications;

using ApplicationLogic.Interfaces;

namespace ApplicationLogic.Services
{
    public class ComputerService: IComputerService
    {
        private UnitOfWork unitOfWork;

        public ComputerService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public IList<Processor> GetProcessors()
        {
            IList<Processor> processors = GetComponents("Processor").Select(component => new Processor
            {
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            }).ToList();

            RetrieveNeededPower(processors);

            return processors;
        }

        public IList<Motherboard> GetMotherboards()
        {
            IList<Motherboard> motherboards = GetComponents("Motherboard").Select(component => new Motherboard
            {
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            }).ToList();

            RetrieveNeededPower(motherboards);

            return motherboards;
        }

        public IList<MemoryCard> GetMemoryCards()
        {
            IList<MemoryCard> memoryCards = GetComponents("Memory Card").Select(component => new MemoryCard
            {
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            }).ToList();

            RetrieveNeededPower(memoryCards);

            return memoryCards;
        }

        public IList<PowerSupply> GetPowerSuppliers()
        {
            IList<PowerSupply> powerSuppliers = GetComponents("Power Supply").Select(component => new PowerSupply
            {
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            }).ToList();

            RetrieveOtherPowerSuppliersData(powerSuppliers);

            return powerSuppliers;
        }

        public IList<SystemBlockHull> GetSystemBlockHulls()
        {
            IList<SystemBlockHull> systemBlockHulls = GetComponents("System Block").Select(component => new SystemBlockHull
            {
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            }).ToList();

            RetrieveOtherSystemBlocksData(systemBlockHulls);

            return systemBlockHulls;

        }

        private void RetrieveOtherSystemBlocksData(IList<SystemBlockHull> systemBlockHulls)
        {
            foreach (SystemBlockHull systemBlockHull in systemBlockHulls)
            {
                SystemBlockSpecification systemBlockSpecification = new SystemBlockSpecification(systemBlockHull.Id);

                Data.SystemBlock systemBlock = unitOfWork.SystemBlockRepository.ReadByQuery(systemBlockSpecification).FirstOrDefault();

                systemBlockHull.AvailablePowerSupplySize = new Tuple<Int32, Int32, Int32>
                    (systemBlock.Width, systemBlock.Height, systemBlock.Length);
            }
        }

        private void RetrieveOtherPowerSuppliersData(IList<PowerSupply> powerSupplies)
        {
            foreach (PowerSupply powerSupply in powerSupplies)
            {
                EnergyProducerSpecification energyProducerSpecification = new EnergyProducerSpecification(powerSupply.Id);

                EnergyProducer energyProducer = unitOfWork.EnergyProducerRepository.ReadByQuery(energyProducerSpecification).FirstOrDefault();

                powerSupply.Size = new Tuple<Int32, Int32, Int32>(energyProducer.Width, energyProducer.Height, energyProducer.Length);
                powerSupply.Power = energyProducer.Power;
            }
        }

        private void RetrieveNeededPower<T>(IList<T> components) where T : SystemComponentBase, IPowerConsumer
        {
            foreach (var component in components)
            {
                EnergyComponentSpecification energyComponentSpecification = new EnergyComponentSpecification(component.Id);

                EnergyComponent energyComponent = unitOfWork.EnergyComponentRepository.ReadByQuery(energyComponentSpecification).FirstOrDefault();
                component.NeededPower = energyComponent.NeededEnergy;
            }
        }

        private IEnumerable<Component> GetComponents(String type)
        {
            ComponentTypeSpecification componentTypeSpecification = new ComponentTypeSpecification(type);

            return unitOfWork.ComponentRepository.ReadByQuery(componentTypeSpecification);
        }
    }
}
