using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.DAO
{
    class MemoryCardDAO : DAO<MemoryCard>
    {
        private static IDictionary<int, MemoryCard> items;

        public MemoryCardDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, MemoryCard>();
                MemoryCard mc;
                mc = new MemoryCard("HyperX DDR4-3200 16384MB", 500, 7);
                items.Add(mc.id, mc);
                mc = new MemoryCard("Kingston DDR3-1333 4096MB", 400, 4);
                items.Add(mc.id, mc);
                mc = new MemoryCard("Goodram DDR4-2400 4096MB", 450, 3);
                items.Add(mc.id, mc);
            }
        }

        public void Create(MemoryCard model)
        {
            items[model.id] = model;
        }

        public void Delete(int id)
        {
            items.Remove(id);
        }

        public MemoryCard Read(int id)
        {
            return items[id];
        }

        public IList<MemoryCard> ReadAll()
        {
            return items.Values.ToList();
        }

        public void Update(int id, MemoryCard model)
        {
            items[id] = model;
        }
    }
}
