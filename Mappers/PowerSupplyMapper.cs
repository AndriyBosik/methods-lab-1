using System;
using System.Linq;

using Models;

using Mappers.Abstraction;
using Mappers.Parsers;

using Data;

namespace Mappers
{
    public class PowerSupplyMapper: IComponentMapper<PowerSupply>
    {
        private ValueParser<Int32> parser;

        public PowerSupplyMapper()
        {
            parser = new IntParser();
        }

        public PowerSupply Map(Component component)
        {
            PowerSupply powerSupply = new PowerSupply
            {
                Type = ComponentType.PowerSupply,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            
            powerSupply.Power = parser.Parse(component.Values, "power");

            Int32 width = parser.Parse(component.Values, "width");
            Int32 height = parser.Parse(component.Values, "height");
            Int32 length = parser.Parse(component.Values, "length");

            powerSupply.Size = new Tuple<Int32, Int32, Int32>(width, height, length);

            return powerSupply;
        }
    }
}
