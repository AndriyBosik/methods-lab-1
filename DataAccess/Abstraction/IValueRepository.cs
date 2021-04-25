using System;

using Data;

namespace DataAccess.Abstraction
{
    public interface IValueRepository: IGenericRepository<Int32, Value>
    {
    }
}
