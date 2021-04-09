using System;
using System.Collections.Generic;
using System.Text;

using Data;

namespace DataAccess.Abstraction
{
    public interface IEnergyProducerRepository: IGenericRepository<Int32, EnergyProducer>
    {
        EnergyProducer ReadByComponentId(Int32 componentId);
    }
}
