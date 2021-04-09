using System;
using System.Collections.Generic;

using Data;

namespace DataAccess.Abstraction
{
    public interface IComponentRepository: IGenericRepository<Int32, Component>
    {
        IEnumerable<Component> ReadAllByType(int type);
    }
}
