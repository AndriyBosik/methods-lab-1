using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstraction
{
    public interface IGenericRepository<K, T>
    {
        Task Create(T entity);

        Task<T> Read(K key);

        Task Update(T entity);

        Task Delete(K key);

        Task<IList<T>> ReadAll();
    }
}
