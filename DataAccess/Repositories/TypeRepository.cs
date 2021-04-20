using System;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class TypeRepository : GenericRepository<Int32, Data.Type>, ITypeRepository
    {
        public TypeRepository(ComputerSalonContext context): base(context) {}
    }
}
