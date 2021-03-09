using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class SystemBlockRepository: IRepository<Int32, SystemBlock>
    {
        private readonly ComputerSalonContext db;

        public SystemBlockRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(SystemBlock entity)
        {
            db.SystemBlocks.Add(entity);
        }

        public void Delete(SystemBlock entity)
        {
            SystemBlock systemBlock = db.SystemBlocks.Find(entity.Id);
            if (systemBlock != null)
            {
                db.SystemBlocks.Remove(entity);
            }
        }

        public SystemBlock Read(Int32 id)
        {
            return db.SystemBlocks.Find(id);
        }

        public IEnumerable<SystemBlock> ReadAll()
        {
            return db.SystemBlocks;
        }

        public IEnumerable<SystemBlock> ReadByQuery(ISpecification<SystemBlock> query)
        {
            return db.SystemBlocks.AsEnumerable().Where(item => query.IsSatisfiedBy(item));
        }

        public void Update(SystemBlock entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
