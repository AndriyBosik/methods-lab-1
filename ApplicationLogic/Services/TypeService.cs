using System;
using System.Collections.Generic;
using System.Linq;

using DataAccess;
using DataAccess.Abstraction;
using DataAccess.Specifications;

using Models;

using ApplicationLogic.Handlers;

namespace ApplicationLogic.Services
{
    public class TypeService
    {
        private readonly UnitOfWork unitOfWork;

        public TypeService()
        {
            unitOfWork = new UnitOfWork();
        }

        public bool IsMultiply(ComponentType componentType)
        {
            SystemComponentTypeHandler handler = new SystemComponentTypeHandler();
            string title = handler.GetStringRepresentation(componentType);

            ISpecification<Data.Type> specification = new TypeSpecification(title);
            return unitOfWork.TypeRepository.ReadByQuery(specification).FirstOrDefault().IsMultiply;
        }
    }
}
