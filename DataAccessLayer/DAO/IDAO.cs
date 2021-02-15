using System;
using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.DAO
{
    interface IDAO<T> where T: BaseEntity<T>
    {
        void Create(T entity);

        T Read(Int32 id);

        void Update(Int32 id, T entity);

        void Delete(T entity);

        IList<T> ReadAll();
    }
}
