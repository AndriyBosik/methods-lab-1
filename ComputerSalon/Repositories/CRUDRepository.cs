using System;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    interface CRUDRepository<T> where T: Base<T>
    {
        void Create(T model);

        T Read(int id);

        void Update(int id, T model);

        void Delete(int id);

        IList<T> ReadAll();
    }
}
