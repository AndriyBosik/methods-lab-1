using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class MemoryCardCRUDRepository : CRUDRepository<MemoryCard>
    {
        private static IDictionary<int, MemoryCard> items;

        public MemoryCardCRUDRepository()
        {
            if (items == null)
            {
                items = new Dictionary<int, MemoryCard>();
            }
        }

        void CRUDRepository<MemoryCard>.Create(MemoryCard model)
        {
            items[model.id] = model;
        }

        void CRUDRepository<MemoryCard>.Delete(int id)
        {
            items.Remove(id);
        }

        MemoryCard CRUDRepository<MemoryCard>.Read(int id)
        {
            return items[id];
        }

        IList<MemoryCard> CRUDRepository<MemoryCard>.ReadAll()
        {
            return items.Values.ToList();
        }

        void CRUDRepository<MemoryCard>.Update(int id, MemoryCard model)
        {
            items[id] = model;
        }
    }
}
