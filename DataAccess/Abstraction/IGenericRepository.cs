using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstraction
{
    public interface IGenericRepository<K, T>
    {
        void Create(T entity);

        T Read(K key);

        void Update(T entity);

        void Delete(K key);

        IEnumerable<T> ReadAll();
    }
}
