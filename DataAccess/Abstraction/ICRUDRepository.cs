using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstraction
{
    public interface ICRUDRepository<K, T>
    {
        void Create(T entity);

        T Read(K id);

        void Update(T entity);

        void Delete(T entity);

        IEnumerable<T> ReadAll();
    }
}
