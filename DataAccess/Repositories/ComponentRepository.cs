using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class ComponentRepository: IComponentRepository
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

        public IEnumerable<Component> ReadAllByType(int type)
        {
            return db.Components.Where(component => component.Group == type);
        }

        public IEnumerable<Component> ReadAll()
        {
            return db.Components;
        }

        public void Update(Component entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
