using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class SystemBlockComponentRepository : IRepository<Int32, SystemBlockComponent>
    {
        private readonly ComputerSalonContext db;

        public SystemBlockComponentRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(SystemBlockComponent entity)
        {
            db.SystemBlockComponents.Add(entity);
        }

        public void Delete(SystemBlockComponent entity)
        {
            SystemBlockComponent component = db.SystemBlockComponents.Find(entity.Id);
            if (component != null)
            {
                db.SystemBlockComponents.Remove(entity);
            }
        }

        public SystemBlockComponent Read(Int32 id)
        {
            return db.SystemBlockComponents.Find(id);
        }

        public IEnumerable<SystemBlockComponent> ReadAll()
        {
            return db.SystemBlockComponents;
        }

        public IEnumerable<SystemBlockComponent> ReadByQuery(ISpecification<SystemBlockComponent> query)
        {
            return db.SystemBlockComponents.Where(item => query.IsSatisfiedBy(item));
        }

        public void Update(SystemBlockComponent entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
