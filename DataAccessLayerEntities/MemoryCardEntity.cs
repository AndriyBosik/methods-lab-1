using System;

namespace DataAccessLayerEntities
{
    public class MemoryCardEntity : SystemComponentBaseEntity<MemoryCardEntity>
    {
        public Int32 NeededPower
        { get; set; }

    }
}
