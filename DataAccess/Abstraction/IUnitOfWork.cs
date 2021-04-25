namespace DataAccess.Abstraction
{
    public interface IUnitOfWork
    {
        public IAttributeRepository AttributeRepository
        { get; }

        public ITypeRepository TypeRepository
        { get; }

        public ISystemBlockRepository SystemBlockRepository
        { get; }

        public ISystemBlockComponentRepository SystemBlockComponentRepository
        { get; }

        public IComponentRepository ComponentRepository
        { get; }

        public IValueRepository ValueRepository
        { get; }

        public void Save();
    }
}
