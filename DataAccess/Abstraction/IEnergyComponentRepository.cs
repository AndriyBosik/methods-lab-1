using System;
using System.Collections.Generic;

using Data;

namespace DataAccess.Abstraction
{
    public interface IEnergyComponentRepository: ICRUDRepository<Int32, EnergyComponent>
    {
        EnergyComponent ReadByComponentId(Int32 componentId);
    }
}
