using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public class SystemBlockHullDAO : IDAO<SystemBlockHullEntity>
    {
        private static IDictionary<Int32, SystemBlockHullEntity> items;

        public SystemBlockHullDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, SystemBlockHullEntity>();
                SystemBlockHullEntity sbh;
                sbh = new SystemBlockHullEntity
                {
                    Title = "Gamdias Athena E1",
                    Price = 2000,
                    AvailablePowerSupplySize = new Tuple<Int32, Int32, Int32>(150, 150, 100)
                };
                items.Add(sbh.Id, sbh);
                sbh = new SystemBlockHullEntity
                {
                    Title = "NZXT H510 Matte Black-Red",
                    Price = 1200,
                    AvailablePowerSupplySize = new Tuple<Int32, Int32, Int32>(120, 120, 70)
                };
                items.Add(sbh.Id, sbh);
                sbh = new SystemBlockHullEntity
                {
                    Title = "Aerocool Split-A-BK-v1 Black",
                    Price = 1500,
                    AvailablePowerSupplySize = new Tuple<Int32, Int32, Int32>(140, 150, 86)
                };
                items.Add(sbh.Id, sbh);
            }
        }
        public void Create(SystemBlockHullEntity entity)
        {
            items[entity.Id] = entity;
        }

        public void Delete(SystemBlockHullEntity entity)
        {
            items.Remove(entity.Id);
        }

        public SystemBlockHullEntity Read(Int32 id)
        {
            return items[id];
        }

        public void Update(SystemBlockHullEntity entity)
        {
            items[entity.Id] = entity;
        }

        public IList<SystemBlockHullEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
