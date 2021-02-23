using System;

namespace DataAccessLayerEntities
{
    public class SystemBlockHullEntity : SystemComponentBaseEntity<SystemBlockHullEntity>
    {
        public Tuple<Int32, Int32, Int32> AvailablePowerSupplySize
        { get; set; }
    }
}
