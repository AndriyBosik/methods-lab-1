using Models;

using Mappers.Abstraction;

namespace ApplicationLogic.Interfaces
{
    interface IMapperFactory
    {
        IComponentMapper<T> GetMapper<T>(ComponentType componentType) where T : SystemComponentBase;
    }
}
