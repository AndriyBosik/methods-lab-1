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

        public IEnumerable<Component> ReadAllByType(int type)
        {
            return context.Components.Where(component => component.Group == type);
        }
    }
}
