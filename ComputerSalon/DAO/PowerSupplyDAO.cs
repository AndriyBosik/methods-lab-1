using System;
using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.DAO
{
    class PowerSupplyDAO : DAO<PowerSupply>
    {
        private static IDictionary<int, PowerSupply> items;

        public PowerSupplyDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, PowerSupply>();
                PowerSupply ps;
                ps = new PowerSupply("Asus TUF Gaming 650 W 80+ Bronze", 150, new Tuple<int, int, int>(150, 150, 86), 20);
                items.Add(ps.id, ps);
                ps = new PowerSupply("GameMax GM-500B", 200, new Tuple<int, int, int>(150, 140, 86), 15);
                items.Add(ps.id, ps);
                ps = new PowerSupply("DeepCool 650W DQ650-M-V2L", 300, new Tuple<int, int, int>(120, 120, 50), 10);
                items.Add(ps.id, ps);
            }
        }

        public void Create(PowerSupply model)
        {
            items[model.id] = model;
        }

        public void Delete(int id)
        {
            items.Remove(id);
        }

        public PowerSupply Read(int id)
        {
            return items[id];
        }

        public IList<PowerSupply> ReadAll()
        {
            return items.Values.ToList();
        }

        public void Update(int id, PowerSupply model)
        {
            items[id] = model;
        }
    }
}
