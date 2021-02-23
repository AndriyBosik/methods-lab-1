using System;

namespace DataAccessLayerEntities
{
    public class MotherboardEntity : SystemComponentBaseEntity<MotherboardEntity>
    {
        public Int32 NeededPower
        { get; set; }
    }
}
