using System;
using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class ProcessorCRUDRepository : CRUDRepository<Processor>
    {
        private static IDictionary<int, Processor> items;

        public ProcessorCRUDRepository()
        {
            if (items == null)
            {
                items = new Dictionary<int, Processor>();
            }
        }

        void CRUDRepository<Processor>.Create(Processor model)
        {
            items[model.id] = model;
        }

        void CRUDRepository<Processor>.Delete(int id)
        {
            items.Remove(id);
        }

        Processor CRUDRepository<Processor>.Read(int id)
        {
            return items[id];
        }

        IList<Processor> CRUDRepository<Processor>.ReadAll()
        {
            return items.Values.ToList();
        }

        void CRUDRepository<Processor>.Update(int id, Processor model)
        {
            items[id] = model;
        }
    }
}
