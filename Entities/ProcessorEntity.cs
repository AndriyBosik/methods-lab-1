using System;

namespace Entities
{
    public class ProcessorEntity : SystemComponentBaseEntity<Int32, ProcessorEntity>
    {
        public Int32 NeededPower
        { get; set; }
    }
}
