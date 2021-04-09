using System;
using System.Collections.Generic;
using System.Text;

using Data;

using DataAccess.Abstraction;
using DataAccess.Repositories;

namespace DataAccess
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ComputerSalonContext context;

        public IGenericRepository<Int32, Data.Type> TypeRepository
        { get; private set; }

        public ISystemBlockHullRepository SystemBlockRepository
        { get; private set; }

        public IGenericRepository<Int32, SystemBlockComponent> SystemBlockComponentRepository
        { get; private set; }

        public IEnergyProducerRepository EnergyProducerRepository
        { get; private set; }

        public IEnergyComponentRepository EnergyComponentRepository
        { get; private set; }

        public IComponentRepository ComponentRepository
        { get; private set; }

        public UnitOfWork()
        {
            context = new ComputerSalonContext();

            TypeRepository = new TypeRepository(context);
            SystemBlockRepository = new SystemBlockHullRepository(context);
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
