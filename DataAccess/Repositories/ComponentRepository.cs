using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class ComponentRepository: GenericRepository<Int32, Component>, IComponentRepository
    {
        public ComponentRepository(ComputerSalonContext context): base(context) {}

        public async Task<IList<Component>> ReadAllByType(Int32 type)
        {
            return await context.Components
                .Include(component => component.Values)
                    .ThenInclude(value => value.Attribute)
                .Where(component => component.TypeId == type)
                .ToListAsync();
        }
    }
}
