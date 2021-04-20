using System;
using System.Collections.Generic;
using System.Text;

using Models;

using Data;

namespace Mappers
{
    public class ProcessorMapper: IComponentMapper<Processor>
    {
        public Processor Map(Component component)
        {
            Processor processor = new Processor
            {
                Type = ComponentType.Processor,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            if (component.EnergyComponent != null)
                processor.NeededPower = component.EnergyComponent.NeededEnergy;

            return processor;
        }
    }
}
