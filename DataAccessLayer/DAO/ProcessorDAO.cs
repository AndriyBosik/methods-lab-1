using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public class ProcessorDAO : IDAO<ProcessorEntity>
    {
        private static IDictionary<Int32, ProcessorEntity> items;

        public ProcessorDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, ProcessorEntity>();
                ProcessorEntity p;
                p = new ProcessorEntity
                {
                    Title = "AMD Ryzen 5 1600 3.2GHz / 16MB",
                    Price = 600,
                    NeededPower = 10
                };
                items.Add(p.Id, p);
                p = new ProcessorEntity
                {
                    Title = "Intel Core i3-10100 3.6GHz / 6MB",
                    Price = 800,
                    NeededPower = 8
                };
                items.Add(p.Id, p);
                p = new ProcessorEntity
                {
                    Title = "Intel Core i5-10600KF 4.1 GHz / 12 MB",
                    Price = 1000,
                    NeededPower = 6
                };
                items.Add(p.Id, p);
            }
        }
        public void Create(ProcessorEntity entity)
        {
            items[entity.Id] = entity;
        }

        public void Delete(ProcessorEntity entity)
        {
            items.Remove(entity.Id);
        }

        public ProcessorEntity Read(Int32 id)
        {
            return items[id];
        }

        public void Update(ProcessorEntity entity)
        {
            items[entity.Id] = entity;
        }

        public IList<ProcessorEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
