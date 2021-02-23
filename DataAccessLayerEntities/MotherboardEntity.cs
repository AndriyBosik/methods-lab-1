using System;

namespace DataAccessLayerEntities
{
    public class MotherboardEntity : SystemComponentBaseEntity<Int32, MotherboardEntity>
    {
        public Int32 NeededPower
        { get; set; }
    }
}
