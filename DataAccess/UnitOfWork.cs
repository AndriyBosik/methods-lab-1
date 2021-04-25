﻿using DataAccess.Abstraction;
using DataAccess.Repositories;

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

        public UnitOfWork()
        {
            context = new ComputerSalonContext();

            AttributeRepository = new AttributeRepository(context);
            TypeRepository = new TypeRepository(context);
            SystemBlockRepository = new SystemBlockRepository(context);
            SystemBlockComponentRepository = new SystemBlockComponentRepository(context);
            ComponentRepository = new ComponentRepository(context);
            ValueRepository = new ValueRepository(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
