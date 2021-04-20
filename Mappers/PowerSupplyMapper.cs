using System;
using System.Collections.Generic;
using System.Text;

using Models;

using Data;

namespace Mappers
{
    public class PowerSupplyMapper: IComponentMapper<PowerSupply>
    {
        public PowerSupply Map(Component component)
        {
            PowerSupply powerSupply = new PowerSupply
            {
                Type = ComponentType.PowerSupply,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            if (component.EnergyProducer != null)
            {
                powerSupply.Size = new Tuple<Int32, Int32, Int32>(component.EnergyProducer.Width, component.EnergyProducer.Height, component.EnergyProducer.Length);
                powerSupply.Power = component.EnergyProducer.Power;
            }
            return powerSupply;
        }
    }
}
