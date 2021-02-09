using System;
using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.DAO
{
    class SystemBlockHullDAO : DAO<SystemBlockHull>
    {
        private static IDictionary<int, SystemBlockHull> items;

        public SystemBlockHullDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, SystemBlockHull>();
                SystemBlockHull sbh;
                sbh = new SystemBlockHull("Gamdias Athena E1", 2000, new Tuple<int, int, int>(150, 150, 100));
                items.Add(sbh.id, sbh);
                sbh = new SystemBlockHull("NZXT H510 Matte Black-Red", 1200, new Tuple<int, int, int>(120, 120, 70));
                items.Add(sbh.id, sbh);
                sbh = new SystemBlockHull("Aerocool Split-A-BK-v1 Black", 1500, new Tuple<int, int, int>(140, 150, 86));
                items.Add(sbh.id, sbh);
            }
        }

        public void Create(SystemBlockHull model)
        {
            items[model.id] = model;
        }

        public void Delete(int id)
        {
            items.Remove(id);
        }

        public SystemBlockHull Read(int id)
        {
            return items[id];
        }

        public IList<SystemBlockHull> ReadAll()
        {
            return items.Values.ToList();
        }

        public void Update(int id, SystemBlockHull model)
        {
            items[id] = model;
        }
    }
}
