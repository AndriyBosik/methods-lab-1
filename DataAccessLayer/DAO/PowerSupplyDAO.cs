using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public class PowerSupplyDAO : IDAO<Int32, PowerSupplyEntity>
    {
        private static IDictionary<Int32, PowerSupplyEntity> items;

        public PowerSupplyDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, PowerSupplyEntity>();
                PowerSupplyEntity ps;
                ps = new PowerSupplyEntity
                {
                    Key = 1,
                    Title = "Asus TUF Gaming 650 W 80+ Bronze",
                    Price = 150,
                    Size = new Tuple<Int32, Int32, Int32>(150, 150, 86),
                    Power = 20
                };
                items.Add(ps.Key, ps);
                ps = new PowerSupplyEntity
                {
                    Key = 2,
                    Title = "GameMax GM-500B",
                    Price = 200,
                    Size = new Tuple<Int32, Int32, Int32>(150, 140, 86),
                    Power = 15
                };
                items.Add(ps.Key, ps);
                ps = new PowerSupplyEntity
                {
                    Key = 3,
                    Title = "DeepCool 650W DQ650-M-V2L",
                    Price = 300,
                    Size = new Tuple<Int32, Int32, Int32>(120, 120, 50),
                    Power = 10
                };
                items.Add(ps.Key, ps);
            }
        }

        public void Create(PowerSupplyEntity entity)
        {
            items[entity.Key] = entity;
        }

        public void Delete(PowerSupplyEntity entity)
        {
            items.Remove(entity.Key);
        }

        public PowerSupplyEntity Read(Int32 key)
        {
            return items[key];
        }

        public void Update(PowerSupplyEntity entity)
        {
            items[entity.Key] = entity;
        }

        public IList<PowerSupplyEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
