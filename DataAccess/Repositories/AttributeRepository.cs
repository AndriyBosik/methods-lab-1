using System;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class AttributeRepository: GenericRepository<Int32, Data.Attribute>, IAttributeRepository
    {
        public AttributeRepository(ComputerSalonContext context): base(context) {}
    }
}
