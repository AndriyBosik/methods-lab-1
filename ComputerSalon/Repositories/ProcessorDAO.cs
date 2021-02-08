using System;
using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class ProcessorDAO : DAO<Processor>
    {
        private static IDictionary<int, Processor> items;

        public ProcessorDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, Processor>();
            }
        }

        void DAO<Processor>.Create(Processor model)
        {
            items[model.id] = model;
        }

        void DAO<Processor>.Delete(int id)
        {
            items.Remove(id);
        }

        Processor DAO<Processor>.Read(int id)
        {
            return items[id];
        }

        IList<Processor> DAO<Processor>.ReadAll()
        {
            return items.Values.ToList();
        }

        void DAO<Processor>.Update(int id, Processor model)
        {
            items[id] = model;
        }
    }
}
