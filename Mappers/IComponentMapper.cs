using System;
using System.Collections.Generic;
using System.Text;

using Data;

using Models;

namespace Mappers
{
    public interface IComponentMapper<T> where T: SystemComponentBase
    {
        T Map(Component component);
    }
}
