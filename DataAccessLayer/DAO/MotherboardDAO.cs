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
                m = new MotherboardEntity("ASRock B460 Pro4", 1000, 15);
                items.Add(m.Id, m);
                m = new MotherboardEntity("Asus Prime H310M-R R2.0", 1234, 10);
                items.Add(m.Id, m);
                m = new MotherboardEntity("MSI MAG Z390 Tomahawk", 1500, 5);
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
