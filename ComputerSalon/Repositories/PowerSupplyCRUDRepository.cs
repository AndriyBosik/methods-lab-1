using System.Linq;
using System.Collections.Generic;

using ComputerSalon.Models;

namespace ComputerSalon.Repositories
{
    class PowerSupplyCRUDRepository : CRUDRepository<PowerSupply>
    {
        private static IDictionary<int, PowerSupply> items;

        public PowerSupplyCRUDRepository()
        {
            if (items == null)
            {
                items = new Dictionary<int, PowerSupply>();
            }
        }

        void CRUDRepository<PowerSupply>.Create(PowerSupply model)
        {
            items[model.id] = model;
        }

        void CRUDRepository<PowerSupply>.Delete(int id)
        {
            items.Remove(id);
        }

        PowerSupply CRUDRepository<PowerSupply>.Read(int id)
        {
            return items[id];
        }

        IList<PowerSupply> CRUDRepository<PowerSupply>.ReadAll()
        {
            return items.Values.ToList();
        }

        void CRUDRepository<PowerSupply>.Update(int id, PowerSupply model)
        {
            items[id] = model;
        }
    }
}
