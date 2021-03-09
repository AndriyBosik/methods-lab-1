using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using Data;

using DataAccess.Abstraction;

namespace DataAccess.Repositories
{
    class EnergyProducerRepository: IRepository<Int32, EnergyProducer>
    {
        private readonly ComputerSalonContext db;

        public EnergyProducerRepository(ComputerSalonContext context)
        {
            db = context;
        }

        public void Create(EnergyProducer entity)
        {
            db.EnergyProducers.Add(entity);
        }

        public void Delete(EnergyProducer entity)
        {
            EnergyProducer energyProducer = db.EnergyProducers.Find(entity.Id);
            if (energyProducer != null)
            {
                db.EnergyProducers.Remove(entity);
            }
        }

        public EnergyProducer Read(Int32 id)
        {
            return db.EnergyProducers.Find(id);
        }

        public IEnumerable<EnergyProducer> ReadAll()
        {
            return db.EnergyProducers;
        }

        public IEnumerable<EnergyProducer> ReadByQuery(ISpecification<EnergyProducer> query)
        {
            return db.EnergyProducers.AsEnumerable().Where(item => query.IsSatisfiedBy(item));
        }

        public void Update(EnergyProducer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
