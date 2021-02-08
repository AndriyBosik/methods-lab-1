using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class PowerSupplyDAO : DAO<PowerSupply>
    {
        private static IDictionary<int, PowerSupply> items;

        public PowerSupplyDAO()
        {
            if (items == null)
            {
                items = new Dictionary<int, PowerSupply>();
            }
        }

        void DAO<PowerSupply>.Create(PowerSupply model)
        {
            items[model.id] = model;
        }

        void DAO<PowerSupply>.Delete(int id)
        {
            items.Remove(id);
        }

        PowerSupply DAO<PowerSupply>.Read(int id)
        {
            return items[id];
        }

        IList<PowerSupply> DAO<PowerSupply>.ReadAll()
        {
            return items.Values.ToList();
        }

        void DAO<PowerSupply>.Update(int id, PowerSupply model)
        {
            items[id] = model;
        }
    }
}
