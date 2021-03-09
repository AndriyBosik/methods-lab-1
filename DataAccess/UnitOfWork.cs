using System;
using System.Collections.Generic;
using System.Text;

using Data;

using DataAccess.Abstraction;
using DataAccess.Repositories;

namespace DataAccess
{
    public class UnitOfWork
    {
        private readonly ComputerSalonContext context;

        public IRepository<Int32, Data.Type> TypeRepository
        { get; private set; }

        public IRepository<Int32, SystemBlock> SystemBlockRepository
        { get; private set; }

        public IRepository<Int32, SystemBlockComponent> SystemBlockComponentRepository
        { get; private set; }

        public IRepository<Int32, EnergyProducer> EnergyProducerRepository
        { get; private set; }

        public IRepository<Int32, EnergyComponent> EnergyComponentRepository
        { get; private set; }

        public IRepository<Int32, Component> ComponentRepository
        { get; private set; }

        public UnitOfWork()
        {
            context = new ComputerSalonContext();

            TypeRepository = new TypeRepository(context);
            SystemBlockRepository = new SystemBlockRepository(context);
            SystemBlockComponentRepository = new SystemBlockComponentRepository(context);
            EnergyProducerRepository = new EnergyProducerRepository(context);
            EnergyComponentRepository = new EnergyComponentRepository(context);
            ComponentRepository = new ComponentRepository(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
