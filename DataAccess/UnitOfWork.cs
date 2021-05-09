using DataAccess.Abstraction;
using DataAccess.Repositories;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ComputerSalonContext context;

        public IAttributeRepository AttributeRepository
        { get; private set; }

        public ITypeRepository TypeRepository
        { get; private set; }

        public ISystemBlockRepository SystemBlockRepository
        { get; private set; }

        public ISystemBlockComponentRepository SystemBlockComponentRepository
        { get; private set; }

        public IComponentRepository ComponentRepository
        { get; private set; }

        public IValueRepository ValueRepository
        { get; private set; }

        public UnitOfWork(ComputerSalonContext context)
        {
            this.context = context;

            AttributeRepository = new AttributeRepository(context);
            TypeRepository = new TypeRepository(context);
            SystemBlockRepository = new SystemBlockRepository(context);
            SystemBlockComponentRepository = new SystemBlockComponentRepository(context);
            ComponentRepository = new ComponentRepository(context);
            ValueRepository = new ValueRepository(context);
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
