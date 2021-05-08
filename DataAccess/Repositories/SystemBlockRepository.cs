using System;
using System.Collections.Generic;
using Data;
using System.Linq;
using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    class SystemBlockRepository : GenericRepository<Int32, SystemBlock>, ISystemBlockRepository
    {
        public SystemBlockRepository(ComputerSalonContext context): base(context) {}

        public IList<SystemBlock> ReadAllWithComponents()
        {
            return context.SystemBlocks
                .Include(systemBlock => systemBlock.SystemBlockComponents)
                    .ThenInclude(systemBlockComponent => systemBlockComponent.Component)
                .ToList();
                
        }
    }
}
