using System;
using System.Collections.Generic;
using Data;

namespace DataAccess.Abstraction
{
    public interface ISystemBlockRepository: IGenericRepository<Int32, SystemBlock>
    {
        public IList<SystemBlock> ReadAllWithComponents();
    }
}
