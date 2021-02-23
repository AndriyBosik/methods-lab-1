using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public class MemoryCardDAO: IDAO<MemoryCardEntity>
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
                    Title = "HyperX DDR4-3200 16384MB",
                    Price = 500,
                    NeededPower = 7
                };
                items.Add(mc.Id, mc);
                mc = new MemoryCardEntity
                {
                    Title = "Kingston DDR3-1333 4096MB",
                    Price = 400,
                    NeededPower = 4
                };
                items.Add(mc.Id, mc);
                mc = new MemoryCardEntity
                {
                    Title = "Goodram DDR4-2400 4096MB",
                    Price = 450,
                    NeededPower = 3
                };
                items.Add(mc.Id, mc);
            }
        }

        public void Create(MemoryCardEntity entity)
        {
            items[entity.Id] = entity;
        }

        public void Delete(MemoryCardEntity entity)
        {
            items.Remove(entity.Id);
        }

        public MemoryCardEntity Read(Int32 id)
        {
            return items[id];
        }

        public void Update(MemoryCardEntity entity)
        {
            items[entity.Id] = entity;
        }

        public IList<MemoryCardEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
