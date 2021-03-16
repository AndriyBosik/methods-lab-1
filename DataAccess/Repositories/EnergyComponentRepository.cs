using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class EnergyComponentRepository: IEnergyComponentRepository
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

        public EnergyComponent ReadByComponentId(Int32 componentId)
        {
            return db.EnergyComponents.Where(component => component.ComponentId == componentId).FirstOrDefault();
        }

        public void Update(EnergyComponent entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
