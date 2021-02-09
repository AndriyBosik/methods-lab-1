using System;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.DAO
{
    interface DAO<T> where T: Base<T>
    {
        void Create(T model);

        T Read(Int32 id);

        void Update(Int32 id, T model);

        void Delete(Int32 id);

        IList<T> ReadAll();
    }
}
