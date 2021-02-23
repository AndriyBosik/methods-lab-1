using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public class MotherboardDAO : IDAO<MotherboardEntity>
    {
        private static IDictionary<Int32, MotherboardEntity> items;

        public MotherboardDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, MotherboardEntity>();
                MotherboardEntity m;
                m = new MotherboardEntity
                {
                    Title = "ASRock B460 Pro4",
                    Price = 1000,
                    NeededPower = 15
                };
                items.Add(m.Id, m);
                m = new MotherboardEntity
                {
                    Title = "Asus Prime H310M-R R2.0",
                    Price = 1234,
                    NeededPower = 10
                };
                items.Add(m.Id, m);
                m = new MotherboardEntity
                {
                    Title = "MSI MAG Z390 Tomahawk",
                    Price = 1500,
                    NeededPower = 5
                };
                items.Add(m.Id, m);
            }
        }
        public void Create(MotherboardEntity entity)
        {
            items[entity.Id] = entity;
        }

        public void Delete(MotherboardEntity entity)
        {
            items.Remove(entity.Id);
        }

        public MotherboardEntity Read(Int32 id)
        {
            return items[id];
        }

        public void Update(MotherboardEntity entity)
        {
            items[entity.Id] = entity;
        }

        public IList<MotherboardEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
