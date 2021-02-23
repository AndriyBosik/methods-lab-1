using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataAccess.DAO
{
    public class MemoryCardDAO: IDAO<Int32, MemoryCardEntity>
    {
        private static IDictionary<Int32, MemoryCardEntity> items;

        public MemoryCardDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, MemoryCardEntity>();
                MemoryCardEntity mc;
                mc = new MemoryCardEntity
                {
                    Key = 1,
                    Title = "HyperX DDR4-3200 16384MB",
                    Price = 500,
                    NeededPower = 7
                };
                items.Add(mc.Key, mc);
                mc = new MemoryCardEntity
                {
                    Key = 2,
                    Title = "Kingston DDR3-1333 4096MB",
                    Price = 400,
                    NeededPower = 4
                };
                items.Add(mc.Key, mc);
                mc = new MemoryCardEntity
                {
                    Key = 3,
                    Title = "Goodram DDR4-2400 4096MB",
                    Price = 450,
                    NeededPower = 3
                };
                items.Add(mc.Key, mc);
            }
        }

        public void Create(MemoryCardEntity entity)
        {
            items[entity.Key] = entity;
        }

        public void Delete(MemoryCardEntity entity)
        {
            items.Remove(entity.Key);
        }

        public MemoryCardEntity Read(Int32 key)
        {
            return items[key];
        }

        public void Update(MemoryCardEntity entity)
        {
            items[entity.Key] = entity;
        }

        public IList<MemoryCardEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
