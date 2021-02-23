using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataAccess.DAO
{
    public class MotherboardDAO : IDAO<Int32, MotherboardEntity>
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
                    Key = 1,
                    Title = "ASRock B460 Pro4",
                    Price = 1000,
                    NeededPower = 15
                };
                items.Add(m.Key, m);
                m = new MotherboardEntity
                {
                    Key = 2,
                    Title = "Asus Prime H310M-R R2.0",
                    Price = 1234,
                    NeededPower = 10
                };
                items.Add(m.Key, m);
                m = new MotherboardEntity
                {
                    Key = 3,
                    Title = "MSI MAG Z390 Tomahawk",
                    Price = 1500,
                    NeededPower = 5
                };
                items.Add(m.Key, m);
            }
        }
        public void Create(MotherboardEntity entity)
        {
            items[entity.Key] = entity;
        }

        public void Delete(MotherboardEntity entity)
        {
            items.Remove(entity.Key);
        }

        public MotherboardEntity Read(Int32 key)
        {
            return items[key];
        }

        public void Update(MotherboardEntity entity)
        {
            items[entity.Key] = entity;
        }

        public IList<MotherboardEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
