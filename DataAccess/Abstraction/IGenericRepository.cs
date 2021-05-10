using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstraction
{
    public interface IGenericRepository<K, T>
    {
        Task CreateAsync(T entity);

        Task<T> ReadAsync(K key);

        Task UpdateAsync(T entity);

        Task DeleteAsync(K key);

        Task<IList<T>> ReadAllAsync();
    }
}
