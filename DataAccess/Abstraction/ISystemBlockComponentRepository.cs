using System;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Abstraction
{
    public interface ISystemBlockComponentRepository: IGenericRepository<Int32, SystemBlockComponent>
    {
    }
}
