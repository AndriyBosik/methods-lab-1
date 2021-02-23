using System;

namespace DataAccessLayerEntities
{
    public class PowerSupplyEntity : SystemComponentBaseEntity<PowerSupplyEntity>
    {
        public Tuple<Int32, Int32, Int32> Size
        { get; set; }

        public Int32 Power
        { get; set; }
    }
}
