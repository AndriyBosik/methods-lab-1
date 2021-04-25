using System;
using System.Linq;

using Models;

using Mappers.Abstraction;
using Mappers.Parsers;

using Data;

namespace Mappers
{
    public class ProcessorMapper: IComponentMapper<Processor>
    {
        private ValueParser<Int32> parser;

        public ProcessorMapper()
        {
            parser = new IntParser();
        }

        public Processor Map(Component component)
        {
            Processor processor = new Processor
            {
                Type = ComponentType.Processor,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            
            processor.NeededPower = parser.Parse(component.Values, "needed_power");

            return processor;
        }
    }
}
