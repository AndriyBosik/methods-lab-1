using System;
using System.Collections.Generic;
using System.Text;

using ApplicationLogic.Interfaces;
using Mappers;
using Models;

namespace ApplicationLogic.Factories
{
    public class MapperFactory : IMapperFactory
    {
        public IComponentMapper<T> GetMapper<T>(ComponentType componentType) where T: SystemComponentBase
        {
            switch (componentType)
            {
                case ComponentType.MemoryCard:
                    return (IComponentMapper<T>)new MemoryCardMapper();
                case ComponentType.Motherboard:
                    return (IComponentMapper<T>)new MotherboardMapper();
                case ComponentType.PowerSupply:
                    return (IComponentMapper<T>)new PowerSupplyMapper();
                case ComponentType.Processor:
                    return (IComponentMapper<T>)new ProcessorMapper();
                case ComponentType.SystemBlockHull:
                    return (IComponentMapper<T>)new SystemBlockHullMapper();
                default:
                    return (IComponentMapper<T>)new MemoryCardMapper();
            }
        }
    }
}
