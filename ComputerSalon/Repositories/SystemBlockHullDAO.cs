using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class SystemBlockHullDAO : DAO<SystemBlockHull>
    {
        private static IDictionary<int, SystemBlockHull> items;

        public SystemBlockHullDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, SystemBlockHull>();
            }
        }

        void DAO<SystemBlockHull>.Create(SystemBlockHull model)
        {
            items[model.id] = model;
        }

        void DAO<SystemBlockHull>.Delete(int id)
        {
            items.Remove(id);
        }

        SystemBlockHull DAO<SystemBlockHull>.Read(int id)
        {
            return items[id];
        }

        IList<SystemBlockHull> DAO<SystemBlockHull>.ReadAll()
        {
            return items.Values.ToList();
        }

        void DAO<SystemBlockHull>.Update(int id, SystemBlockHull model)
        {
            items[id] = model;
        }
    }
}
