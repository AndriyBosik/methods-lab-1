using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class MotherboardDAO : DAO<Motherboard>
    {
        private static IDictionary<int, Motherboard> items;

        public MotherboardDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, Motherboard>();
            }
        }

        void DAO<Motherboard>.Create(Motherboard model)
        {
            items[model.id] = model;
        }

        void DAO<Motherboard>.Delete(int id)
        {
            items.Remove(id);
        }

        Motherboard DAO<Motherboard>.Read(int id)
        {
            return items[id];
        }

        IList<Motherboard> DAO<Motherboard>.ReadAll()
        {
            return items.Values.ToList();
        }

        void DAO<Motherboard>.Update(int id, Motherboard model)
        {
            items[id] = model;
        }
    }
}
