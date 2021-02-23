using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogic.Interfaces;
using BusinessLogic.Containers;
using Models;

namespace BusinessLogic.Factories
{
    public static class ContainerFactory
    {
        public static IContainer GetContainer(SystemComponentType componentType)
        {
            switch (componentType)
            {
                case SystemComponentType.MemoryCard:
                    return new MemoryCardContainer();
                case SystemComponentType.Motherboard:
                    return new MotherboardContainer();
                case SystemComponentType.PowerSupply:
                    return new PowerSupplyContainer();
                case SystemComponentType.Processor:
                    return new ProcessorContainer();
                case SystemComponentType.SystemBlockHull:
                    return new SystemBlockHullContainer();
                default:
                    return new SystemBlockHullContainer();
            }
        }
    }
}
