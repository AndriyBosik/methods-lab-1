using System;
using System.Collections.Generic;
using System.Text;

using Data;

namespace DataAccess.Abstraction
{
    public interface IUnitOfWork
    {
        public ISystemBlockHullRepository SystemBlockRepository
        { get; }

        public IGenericRepository<Int32, SystemBlockComponent> SystemBlockComponentRepository
        { get; }

        public IEnergyProducerRepository EnergyProducerRepository
        { get; }

        public IEnergyComponentRepository EnergyComponentRepository
        { get; }

        public IComponentRepository ComponentRepository
        { get; }

        public void Save();
    }
}
