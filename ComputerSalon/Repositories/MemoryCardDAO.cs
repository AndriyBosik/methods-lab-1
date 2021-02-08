using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class MemoryCardDAO : DAO<MemoryCard>
    {
        private static IDictionary<int, MemoryCard> items;

        public MemoryCardDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, MemoryCard>();
            }
        }

        void DAO<MemoryCard>.Create(MemoryCard model)
        {
            items[model.id] = model;
        }

        void DAO<MemoryCard>.Delete(int id)
        {
            items.Remove(id);
        }

        MemoryCard DAO<MemoryCard>.Read(int id)
        {
            return items[id];
        }

        IList<MemoryCard> DAO<MemoryCard>.ReadAll()
        {
            return items.Values.ToList();
        }

        void DAO<MemoryCard>.Update(int id, MemoryCard model)
        {
            items[id] = model;
        }
    }
}
