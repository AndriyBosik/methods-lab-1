using System;
using System.Collections.Generic;
using System.Linq;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Specifications
{
    public class ComponentTypeSpecification : ISpecification<Component>
    {
        public Int32 typeId;

        public ComponentTypeSpecification(String typeName)
        {
            TypeSpecification typeSpecification = new TypeSpecification(typeName);

            UnitOfWork unitOfWork = new UnitOfWork();
            Data.Type type = unitOfWork.TypeRepository.ReadByQuery(typeSpecification).FirstOrDefault();

            this.typeId = type.Id;
        }

        public bool IsSatisfiedBy(Component entity)
        {
            return entity.TypeID == typeId;
        }
    }
}
