using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data;

namespace DataAccess.Abstraction
{
    public interface IComponentRepository: IGenericRepository<Int32, Component>
    {
        Task<IList<Component>> ReadAllByTypeAsync(int type);
    }
}
