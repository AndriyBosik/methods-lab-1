using System;
using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.DAO
{
    class ProcessorDAO : DAO<Processor>
    {
        private static IDictionary<int, Processor> items;

        public ProcessorDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, Processor>();
                Processor p;
                p = new Processor("AMD Ryzen 5 1600 3.2GHz / 16MB", 600, 10);
                items.Add(p.id, p);
                p = new Processor("Intel Core i3-10100 3.6GHz / 6MB", 800, 8);
                items.Add(p.id, p);
                p = new Processor("Intel Core i5-10600KF 4.1 GHz / 12 MB", 1000, 6);
                items.Add(p.id, p);
            }
        }

        public void Create(Processor model)
        {
            items[model.id] = model;
        }

        public void Delete(int id)
        {
            items.Remove(id);
        }

        public Processor Read(int id)
        {
            return items[id];
        }

        public IList<Processor> ReadAll()
        {
            return items.Values.ToList();
        }

        public void Update(int id, Processor model)
        {
            items[id] = model;
        }
    }
}
