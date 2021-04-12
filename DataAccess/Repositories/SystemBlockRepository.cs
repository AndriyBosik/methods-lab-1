using System;
using System.Collections.Generic;
using Data;
using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    class SystemBlockRepository : GenericRepository<Int32, SystemBlock>, ISystemBlockRepository
    {
        public SystemBlockRepository(ComputerSalonContext context): base(context) {}
    }
}
