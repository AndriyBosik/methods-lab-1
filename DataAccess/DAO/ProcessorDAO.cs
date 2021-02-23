using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataAccess.DAO
{
    public class ProcessorDAO : IDAO<Int32, ProcessorEntity>
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
                    Key = 1,
                    Title = "AMD Ryzen 5 1600 3.2GHz / 16MB",
                    Price = 600,
                    NeededPower = 10
                };
                items.Add(p.Key, p);
                p = new ProcessorEntity
                {
                    Key = 2,
                    Title = "Intel Core i3-10100 3.6GHz / 6MB",
                    Price = 800,
                    NeededPower = 8
                };
                items.Add(p.Key, p);
                p = new ProcessorEntity
                {
                    Key = 3,
                    Title = "Intel Core i5-10600KF 4.1 GHz / 12 MB",
                    Price = 1000,
                    NeededPower = 6
                };
                items.Add(p.Key, p);
            }
        }
        public void Create(ProcessorEntity entity)
        {
            items[entity.Key] = entity;
        }

        public void Delete(ProcessorEntity entity)
        {
            items.Remove(entity.Key);
        }

        public ProcessorEntity Read(Int32 key)
        {
            return items[key];
        }

        public void Update(ProcessorEntity entity)
        {
            items[entity.Key] = entity;
        }

        public IList<ProcessorEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
