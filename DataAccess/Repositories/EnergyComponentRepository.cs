using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class EnergyComponentRepository: IRepository<Int32, EnergyComponent>
    {
        private readonly ComputerSalonContext db;

        public EnergyComponentRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(EnergyComponent entity)
        {
            db.EnergyComponents.Add(entity);
        }

        public void Delete(EnergyComponent entity)
        {
            EnergyComponent energyComponent = db.EnergyComponents.Find(entity.Id);
            if (energyComponent != null)
            {
                db.EnergyComponents.Remove(entity);
            }
        }

        public EnergyComponent Read(Int32 id)
        {
            return db.EnergyComponents.Find(id);
        }

        public IEnumerable<EnergyComponent> ReadAll()
        {
            return db.EnergyComponents;
        }

        public IEnumerable<EnergyComponent> ReadByQuery(ISpecification<EnergyComponent> query)
        {
            return db.EnergyComponents.AsEnumerable().Where(item => query.IsSatisfiedBy(item));
        }

        public void Update(EnergyComponent entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
