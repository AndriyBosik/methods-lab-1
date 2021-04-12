using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class TypeRepository : GenericRepository<Int32, Data.Type>
    {
        public TypeRepository(ComputerSalonContext context): base(context) {}
    }
}
