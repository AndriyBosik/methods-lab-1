using System;

namespace DataAccessLayerEntities
{
    public class SystemBlockHullEntity : SystemComponentBaseEntity<Int32, SystemBlockHullEntity>
    {
        public Tuple<Int32, Int32, Int32> AvailablePowerSupplySize
        { get; set; }
    }
}
