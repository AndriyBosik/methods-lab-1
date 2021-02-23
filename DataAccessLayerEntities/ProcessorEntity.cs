using System;

namespace DataAccessLayerEntities
{
    public class ProcessorEntity : SystemComponentBaseEntity<Int32, ProcessorEntity>
    {
        public Int32 NeededPower
        { get; set; }
    }
}
