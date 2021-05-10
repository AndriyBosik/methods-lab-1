using System;
using System.Collections.Generic;
using System.Linq;

using DataAccess;
using DataAccess.Abstraction;

using Models;

using ApplicationLogic.Interfaces;
using System.Threading.Tasks;

namespace ApplicationLogic.Services
{
    public class TypeService: ITypeService
    {
        private readonly IUnitOfWork unitOfWork;

        public TypeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> IsMultiplyAsync(ComponentType componentType)
        {
            return (await unitOfWork.TypeRepository.ReadAsync((Int32) componentType)).IsMultiply;
        }
    }
}
