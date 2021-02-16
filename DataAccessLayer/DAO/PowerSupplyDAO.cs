using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public class PowerSupplyDAO : IDAO<PowerSupplyEntity>
    {
        private static IDictionary<Int32, PowerSupplyEntity> items;

        public PowerSupplyDAO()
        {
            if (items == null)
            {
                items = new Dictionary<Int32, PowerSupplyEntity>();
                PowerSupplyEntity ps;
                ps = new PowerSupplyEntity("Asus TUF Gaming 650 W 80+ Bronze", 150, new Tuple<Int32, Int32, Int32>(150, 150, 86), 20);
                items.Add(ps.Id, ps);
                ps = new PowerSupplyEntity("GameMax GM-500B", 200, new Tuple<Int32, Int32, Int32>(150, 140, 86), 15);
                items.Add(ps.Id, ps);
                ps = new PowerSupplyEntity("DeepCool 650W DQ650-M-V2L", 300, new Tuple<Int32, Int32, Int32>(120, 120, 50), 10);
                items.Add(ps.Id, ps);
            }
        }

        public void Create(PowerSupplyEntity entity)
        {
            items[entity.Id] = entity;
        }

        public void Delete(PowerSupplyEntity entity)
        {
            items.Remove(entity.Id);
        }

        public PowerSupplyEntity Read(Int32 id)
        {
            return items[id];
        }

        public void Update(PowerSupplyEntity entity)
        {
            items[entity.Id] = entity;
        }

        public IList<PowerSupplyEntity> ReadAll()
        {
            return items.Values.ToList();
        }
    }
}
