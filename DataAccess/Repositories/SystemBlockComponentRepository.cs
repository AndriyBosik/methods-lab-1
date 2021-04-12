using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class SystemBlockComponentRepository: GenericRepository<Int32, SystemBlockComponent>, ISystemBlockComponentRepository
    {
        public SystemBlockComponentRepository(ComputerSalonContext context): base(context) {}
    }
}
