using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class SystemBlockHullCRUDRepository : CRUDRepository<SystemBlockHull>
    {
        private static IDictionary<int, SystemBlockHull> items;

        public SystemBlockHullCRUDRepository()
        {
            if (items == null)
            {
                items = new Dictionary<int, SystemBlockHull>();
            }
        }

        void CRUDRepository<SystemBlockHull>.Create(SystemBlockHull model)
        {
            items[model.id] = model;
        }

        void CRUDRepository<SystemBlockHull>.Delete(int id)
        {
            items.Remove(id);
        }

        SystemBlockHull CRUDRepository<SystemBlockHull>.Read(int id)
        {
            return items[id];
        }

        IList<SystemBlockHull> CRUDRepository<SystemBlockHull>.ReadAll()
        {
            return items.Values.ToList();
        }

        void CRUDRepository<SystemBlockHull>.Update(int id, SystemBlockHull model)
        {
            items[id] = model;
        }
    }
}
