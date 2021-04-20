using System;
using System.Collections.Generic;
using System.Text;

using Models;

using Mappers;

namespace ApplicationLogic.Interfaces
{
    interface IMapperFactory
    {
        IComponentMapper<T> GetMapper<T>(ComponentType componentType) where T : SystemComponentBase;
    }
}
