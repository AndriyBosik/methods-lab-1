using System;
using System.Linq;

using Data;

using Mappers.Abstraction;
using Mappers.Parsers;

using Models;

namespace Mappers
{
    public class MemoryCardMapper: IComponentMapper<MemoryCard>
    {
        private ValueParser<Int32> parser;

        public MemoryCardMapper()
        {
            parser = new IntParser();
        }

        public MemoryCard Map(Component component)
        {
            MemoryCard memoryCard = new MemoryCard
            {
                Type = ComponentType.MemoryCard,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };

            memoryCard.NeededPower = parser.Parse(component.Values, "needed_power");

            return memoryCard;
        }
    }
}
