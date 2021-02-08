using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class MotherboardCRUDRepository : CRUDRepository<Motherboard>
    {
        private static IDictionary<int, Motherboard> items;

        public MotherboardCRUDRepository()
        {
            if (items == null)
            {
                items = new Dictionary<int, Motherboard>();
            }
        }

        void CRUDRepository<Motherboard>.Create(Motherboard model)
        {
            items[model.id] = model;
        }

        void CRUDRepository<Motherboard>.Delete(int id)
        {
            items.Remove(id);
        }

        Motherboard CRUDRepository<Motherboard>.Read(int id)
        {
            return items[id];
        }

        IList<Motherboard> CRUDRepository<Motherboard>.ReadAll()
        {
            return items.Values.ToList();
        }

        void CRUDRepository<Motherboard>.Update(int id, Motherboard model)
        {
            items[id] = model;
        }
    }
}
