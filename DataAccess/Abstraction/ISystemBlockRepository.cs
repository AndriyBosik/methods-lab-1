using System;
using System.Collections.Generic;

using Data;

namespace DataAccess.Abstraction
{
    public interface ISystemBlockRepository: ICRUDRepository<Int32, SystemBlock>
    {
        SystemBlock ReadByComponentId(Int32 componentId);
    }
}
