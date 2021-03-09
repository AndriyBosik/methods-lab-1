using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Containers;
using Models;

namespace ApplicationLogic.Factories
{
    public static class ContainerFactory
    {
        public static IContainer GetContainer(ComponentType componentType)
        {
            switch (componentType)
            {
                case ComponentType.MemoryCard:
                    return new MemoryCardContainer();
                case ComponentType.Motherboard:
                    return new MotherboardContainer();
                case ComponentType.PowerSupply:
                    return new PowerSupplyContainer();
                case ComponentType.Processor:
                    return new ProcessorContainer();
                case ComponentType.SystemBlockHull:
                    return new SystemBlockHullContainer();
                default:
                    return new SystemBlockHullContainer();
            }
        }
    }
}
