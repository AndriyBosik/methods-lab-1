using System;
using System.Collections.Generic;
using System.Linq;

using DataAccess;
using DataAccess.Abstraction;

using Models;

using ApplicationLogic.Interfaces;

namespace ApplicationLogic.Services
{
    public class TypeService: ITypeService
    {
        private readonly IUnitOfWork unitOfWork;

        public TypeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool IsMultiply(ComponentType componentType)
        {
            return unitOfWork.TypeRepository.Read((Int32) componentType).IsMultiply;
        }
    }
}
