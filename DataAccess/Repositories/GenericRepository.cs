using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task Create(T entity)
        {
            await table.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task Delete(K key)
        {
            T obj = await table.FindAsync(key);
            table.Remove(obj);
            await this.context.SaveChangesAsync();
        }

        public async Task<T> Read(K key)
        {
            return await table.FindAsync(key);
        }

        public async Task<IList<T>> ReadAll()
        {
            return await table.ToListAsync();
        }

        public async Task Update(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
        }
    }
}
