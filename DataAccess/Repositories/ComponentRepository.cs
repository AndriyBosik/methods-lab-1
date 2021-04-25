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

        public IList<Component> ReadAllByType(Int32 type)
        {
            return context.Components
                .Include(component => component.Values)
                    .ThenInclude(value => value.Attribute)
                .Where(component => component.TypeId == type)
                .ToList();
        }
    }
}
