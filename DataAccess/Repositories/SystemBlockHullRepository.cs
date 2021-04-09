using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class SystemBlockHullRepository: ISystemBlockHullRepository
    {
        private readonly ComputerSalonContext db;

        public SystemBlockHullRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(SystemBlockHull entity)
        {
            db.SystemBlockHulls.Add(entity);
        }

        public void Delete(SystemBlockHull entity)
        {
            SystemBlockHull systemBlock = db.SystemBlockHulls.Find(entity.Id);
            if (systemBlock != null)
            {
                db.SystemBlockHulls.Remove(entity);
            }
        }

        public SystemBlockHull Read(Int32 id)
        {
            return db.SystemBlockHulls.Find(id);
        }

        public IEnumerable<SystemBlockHull> ReadAll()
        {
            return db.SystemBlockHulls;
        }

        public SystemBlockHull ReadByComponentId(Int32 componentId)
        {
            return db.SystemBlockHulls.Where(component => component.ComponentId == componentId).FirstOrDefault();
        }

        public void Update(SystemBlockHull entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
