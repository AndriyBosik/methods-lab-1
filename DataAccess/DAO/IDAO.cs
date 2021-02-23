using System;
using System.Collections.Generic;

using Entities;

namespace DataAccess.DAO
{
    // K - Primary Key; T - Entity Type
    public interface IDAO<K, T> where T: BaseEntity<K, T>
    {
        void Create(T entity);

        T Read(K key);

        void Update(T entity);

        void Delete(T entity);

        IList<T> ReadAll();
    }
}
