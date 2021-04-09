using System;
using System.Collections.Generic;

using Data;

namespace DataAccess.Abstraction
{
    public interface ISystemBlockHullRepository: IGenericRepository<Int32, SystemBlockHull>
    {
        SystemBlockHull ReadByComponentId(Int32 componentId);
    }
}
