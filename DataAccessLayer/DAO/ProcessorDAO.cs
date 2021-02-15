using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    class ProcessorDAO : IDAO<ProcessorEntity>
    {
        private static IDictionary<Int32, ProcessorEntity> items;

        public ProcessorDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, ProcessorEntity>();
                ProcessorEntity p;
                p = new ProcessorEntity("AMD Ryzen 5 1600 3.2GHz / 16MB", 600, 10);
                items.Add(p.Id, p);
                p = new ProcessorEntity("Intel Core i3-10100 3.6GHz / 6MB", 800, 8);
                items.Add(p.Id, p);
                p = new ProcessorEntity("Intel Core i5-10600KF 4.1 GHz / 12 MB", 1000, 6);
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
