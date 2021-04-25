using System;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class ValueRepository: GenericRepository<Int32, Value>, IValueRepository
    {
        public ValueRepository(ComputerSalonContext context): base(context) {}
    }
}
