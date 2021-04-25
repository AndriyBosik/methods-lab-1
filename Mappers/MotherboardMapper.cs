using System;
using System.Linq;

using Data;

using Mappers.Abstraction;
using Mappers.Parsers;

using Models;

namespace Mappers
{
    public class MotherboardMapper: IComponentMapper<Motherboard>
    {
        private ValueParser<Int32> parser;

        public MotherboardMapper()
        {
            parser = new IntParser();
        }

        public Motherboard Map(Component component)
        {
            Motherboard motherboard = new Motherboard
            {
                Type = ComponentType.Motherboard,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            
            motherboard.NeededPower = parser.Parse(component.Values, "needed_power");

            return motherboard;
        }
    }
}
