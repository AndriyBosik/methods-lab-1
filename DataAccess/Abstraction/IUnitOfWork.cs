using System;
using System.Collections.Generic;
using System.Text;

using Data;

namespace DataAccess.Abstraction
{
    public interface IUnitOfWork
    {
        public ITypeRepository TypeRepository
        { get; }

        public ISystemBlockHullRepository SystemBlockHullRepository
        { get; }

        public ISystemBlockRepository SystemBlockRepository
        { get; }

        public ISystemBlockComponentRepository SystemBlockComponentRepository
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
