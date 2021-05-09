using System;
using System.Collections.Generic;
using Data;
using System.Linq;
using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class SystemBlockRepository : GenericRepository<Int32, SystemBlock>, ISystemBlockRepository
    {
        public SystemBlockRepository(ComputerSalonContext context): base(context) {}

        public async Task<IList<SystemBlock>> ReadAllWithComponents()
        {
            return await context.SystemBlocks
                .Include(systemBlock => systemBlock.SystemBlockComponents)
                    .ThenInclude(systemBlockComponent => systemBlockComponent.Component)
                .ToListAsync();
                
        }
    }
}
