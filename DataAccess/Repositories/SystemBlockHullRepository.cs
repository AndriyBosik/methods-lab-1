using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class SystemBlockHullRepository: GenericRepository<Int32, SystemBlockHull>, ISystemBlockHullRepository
    {
        public SystemBlockHullRepository(ComputerSalonContext context): base(context) {}

        public SystemBlockHull ReadByComponentId(Int32 componentId)
        {
            return context.SystemBlockHulls.Where(component => component.ComponentId == componentId).FirstOrDefault();
        }
    }
}
