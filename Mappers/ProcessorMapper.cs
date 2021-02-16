using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using DataAccessLayerEntities;

namespace Mappers
{
    public static class ProcessorMapper
    {
        public static ProcessorEntity ToEntity(this Processor processor)
        {
            return new ProcessorEntity(processor.Title, processor.Price, processor.NeededPower);
        }

        public static Processor ToModel(this ProcessorEntity processor)
        {
            return new Processor(processor.Title, processor.Price, processor.NeededPower);
        }
    }
}
