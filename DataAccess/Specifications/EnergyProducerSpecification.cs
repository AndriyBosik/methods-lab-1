using System;
using System.Collections.Generic;
using System.Text;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Specifications
{
    public class EnergyProducerSpecification: ISpecification<EnergyProducer>
    {
        private Int32 id;

        public EnergyProducerSpecification(Int32 id)
        {
            this.id = id;
        }

        public bool IsSatisfiedBy(EnergyProducer entity)
        {
            return entity.ComponentId == id;
        }
    }
}
