using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data;

namespace DataAccess.Abstraction
{
    public interface ISystemBlockRepository: IGenericRepository<Int32, SystemBlock>
    {
        public Task<IList<SystemBlock>> ReadAllWithComponents();
    }
}
