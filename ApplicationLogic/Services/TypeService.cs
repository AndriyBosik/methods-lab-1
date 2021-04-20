using System;
using System.Collections.Generic;
using System.Linq;

using DataAccess;
using DataAccess.Abstraction;

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
            return unitOfWork.TypeRepository.Read((Int32) componentType).IsMultiply;
        }
    }
}
