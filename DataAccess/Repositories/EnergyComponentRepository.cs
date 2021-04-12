using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class EnergyComponentRepository: GenericRepository<Int32, EnergyComponent>, IEnergyComponentRepository
    {
        public EnergyComponentRepository(ComputerSalonContext context): base(context) {}

        public EnergyComponent ReadByComponentId(Int32 componentId)
        {
            return context.EnergyComponents.Where(component => component.ComponentId == componentId).FirstOrDefault();
        }
    }
}
