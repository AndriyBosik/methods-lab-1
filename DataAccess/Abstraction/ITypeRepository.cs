using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstraction
{
    public interface ITypeRepository: IGenericRepository<Int32, Data.Type>
    {
    }
}
