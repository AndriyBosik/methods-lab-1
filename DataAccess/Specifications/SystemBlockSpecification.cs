using System;
using System.Collections.Generic;
using System.Text;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Specifications
{
    public class SystemBlockSpecification: ISpecification<SystemBlockHull>
    {
        private Int32 id;

        public SystemBlockSpecification(Int32 id)
        {
            this.id = id;
        }

        public bool IsSatisfiedBy(SystemBlockHull entity)
        {
            return entity.ComponentId == id;
        }
    }
}
