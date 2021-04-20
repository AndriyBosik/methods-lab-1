using System;
using System.Collections.Generic;
using System.Text;

using Data;

using Models;

namespace Mappers
{
    public class MemoryCardMapper: IComponentMapper<MemoryCard>
    {
        public MemoryCard Map(Component component)
        {
            MemoryCard memoryCard = new MemoryCard
            {
                Type = ComponentType.MemoryCard,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            
            if (component.EnergyComponent != null)
                memoryCard.NeededPower = component.EnergyComponent.NeededEnergy;

            return memoryCard;
        }
    }
}
