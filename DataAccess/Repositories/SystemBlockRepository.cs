using System;
using System.Collections.Generic;
using Data;
using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    class SystemBlockRepository : ISystemBlockRepository
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

        public SystemBlock Read(int id)
        {
            return db.SystemBlocks.Find(id);
        }

        public IEnumerable<SystemBlock> ReadAll()
        {
            return db.SystemBlocks;
        }

        public void Update(SystemBlock entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
