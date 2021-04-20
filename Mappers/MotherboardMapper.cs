using System;
using System.Collections.Generic;
using System.Text;

using Data;

using Models;

namespace Mappers
{
    public class MotherboardMapper: IComponentMapper<Motherboard>
    {
        public Motherboard Map(Component component)
        {
            Motherboard motherboard = new Motherboard
            {
                Type = ComponentType.Motherboard,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            if (component.EnergyComponent != null)
                motherboard.NeededPower = component.EnergyComponent.NeededEnergy;

            return motherboard;
        }
    }
}
