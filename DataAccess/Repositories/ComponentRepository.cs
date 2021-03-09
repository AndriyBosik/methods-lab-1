using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class ComponentRepository: IRepository<Int32, Component>
    {
        private readonly ComputerSalonContext db;

        public ComponentRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(Component entity)
        {
            db.Components.Add(entity);
        }

        public void Delete(Component entity)
        {
            Component component = db.Components.Find(entity.Id);
            if (component != null)
            {
                db.Components.Remove(entity);
            }
        }

        public Component Read(Int32 id)
        {
            return db.Components.Find(id);
        }

        public IEnumerable<Component> ReadAll()
        {
            return db.Components;
        }

        public IEnumerable<Component> ReadByQuery(ISpecification<Component> query)
        {
            return db.Components.AsEnumerable().Where(item => query.IsSatisfiedBy(item));
        }

        public void Update(Component entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
