using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.DAO
{
    class MotherboardDAO : DAO<Motherboard>
    {
        private static IDictionary<int, Motherboard> items;

        public MotherboardDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, Motherboard>();
                Motherboard m;
                m = new Motherboard("ASRock B460 Pro4", 1000, 15);
                items.Add(m.id, m);
                m = new Motherboard("Asus Prime H310M-R R2.0", 1234, 10);
                items.Add(m.id, m);
                m = new Motherboard("MSI MAG Z390 Tomahawk", 1500, 5);
                items.Add(m.id, m);
            }
        }

        public void Create(Motherboard model)
        {
            items[model.id] = model;
        }

        public void Delete(int id)
        {
            items.Remove(id);
        }

        public Motherboard Read(int id)
        {
            return items[id];
        }

        public IList<Motherboard> ReadAll()
        {
            return items.Values.ToList();
        }

        public void Update(int id, Motherboard model)
        {
            items[id] = model;
        }
    }
}
