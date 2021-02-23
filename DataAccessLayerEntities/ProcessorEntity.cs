using System;

namespace DataAccessLayerEntities
{
    public class ProcessorEntity : SystemComponentBaseEntity<ProcessorEntity>
    {
        public Int32 NeededPower
        { get; set; }
    }
}
