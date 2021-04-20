using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    class GenericRepository<K, T>: IGenericRepository<K, T> where T: class
    {
        protected readonly ComputerSalonContext context;
        private readonly DbSet<T> table;

        public GenericRepository(ComputerSalonContext context)
        {
            this.context = context;
            this.table = this.context.Set<T>();
        }

        public void Create(T entity)
        {
            table.Add(entity);
        }

        public void Delete(K key)
        {
            T obj = table.Find(key);
            table.Remove(obj);
        }

        public T Read(K key)
        {
            return table.Find(key);
        }

        public IList<T> ReadAll()
        {
            return table.ToList();
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            this.context.Entry(entity).State = EntityState.Modified;
        }
    }
}
