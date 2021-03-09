using System;
using System.Collections.Generic;
using System.Text;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Specifications
{
    public class EnergyComponentSpecification : ISpecification<EnergyComponent>
    {
        private Int32 id;

        public EnergyComponentSpecification(Int32 id)
        {
            this.id = id;
        }

        public bool IsSatisfiedBy(EnergyComponent entity)
        {
            return entity.ComponentId == id;
        }
    }
}
