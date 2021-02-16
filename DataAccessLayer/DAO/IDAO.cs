using System;
using System.Collections.Generic;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public interface IDAO<T> where T: BaseEntity<T>
    {
        void Create(T entity);

        T Read(Int32 id);

        void Update(T entity);

        void Delete(T entity);

        IList<T> ReadAll();
    }
}
