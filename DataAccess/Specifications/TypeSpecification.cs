using System;
using System.Collections.Generic;
using System.Text;

using DataAccess.Abstraction;

namespace DataAccess.Specifications
{
    public class TypeSpecification : ISpecification<Data.Type>
    {
        private String typeName;

        public TypeSpecification(string typeName)
        {
            this.typeName = typeName;
        }

        public bool IsSatisfiedBy(Data.Type entity)
        {
            return entity.Title.Equals(typeName);
        }
    }
}
