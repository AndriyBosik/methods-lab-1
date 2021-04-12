using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class EnergyProducerRepository: GenericRepository<Int32, EnergyProducer>, IEnergyProducerRepository
    {
        public EnergyProducerRepository(ComputerSalonContext context): base(context) {}

        public EnergyProducer ReadByComponentId(Int32 componentId)
        {
            return context.EnergyProducers.Where(component => component.ComponentId == componentId).FirstOrDefault();
        }
    }
}
