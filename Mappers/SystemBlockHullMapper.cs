using System;
using System.Linq;

using Data;

using Mappers.Abstraction;
using Mappers.Parsers;

using Models;

namespace Mappers
{
    public class SystemBlockHullMapper: IComponentMapper<Models.SystemBlockHull>
    {
        private ValueParser<Int32> parser;

        public SystemBlockHullMapper()
        {
            parser = new IntParser();
        }

        public Models.SystemBlockHull Map(Component component)
        {
            Models.SystemBlockHull systemBlockHull = new Models.SystemBlockHull
            {
                Type = ComponentType.SystemBlockHull,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };

            Int32 width = parser.Parse(component.Values, "width");
            Int32 height = parser.Parse(component.Values, "height");
            Int32 length = parser.Parse(component.Values, "length");

            systemBlockHull.AvailablePowerSupplySize = new Tuple<Int32, Int32, Int32>(width, height, length);

            return systemBlockHull;
        }
    }
}
