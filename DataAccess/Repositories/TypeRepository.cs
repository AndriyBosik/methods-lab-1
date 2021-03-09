using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class TypeRepository : IRepository<Int32, Data.Type>
    {
        private readonly ComputerSalonContext db;

        public TypeRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(Data.Type entity)
        {
            db.Types.Add(entity);
        }

        public void Delete(Data.Type entity)
        {
            Data.Type type = db.Types.Find(entity.Id);
            if (type != null)
            {
                db.Types.Remove(entity);
            }
        }

        public Data.Type Read(Int32 id)
        {
            return db.Types.Find(id);
        }

        public IEnumerable<Data.Type> ReadAll()
        {
            return db.Types;
        }

        public IEnumerable<Data.Type> ReadByQuery(ISpecification<Data.Type> query)
        {
            return db.Types.AsEnumerable().Where(item => query.IsSatisfiedBy(item));
        }

        public void Update(Data.Type entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
