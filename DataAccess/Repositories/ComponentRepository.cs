using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class ComponentRepository: GenericRepository<Int32, Component>, IComponentRepository
    {
        public ComponentRepository(ComputerSalonContext context): base(context) {}

        public IList<Component> ReadAllByType(int type)
        {
            return context.Components
                .Include(component => component.SystemBlockHull)
                .Include(component => component.EnergyComponent)
                .Include(component => component.EnergyProducer)
                .Where(component => component.Group == type)
                .ToList();
        }
    }
}
