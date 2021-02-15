using System;

namespace DataAccessLayerEntities
{
    public class SystemBlockHullEntity : SystemComponentBaseEntity<SystemBlockHullEntity>
    {
        public Tuple<Int32, Int32, Int32> AvailablePowerSupplySize
        { get; set; }

        public SystemBlockHullEntity(string title, Int32 price, Tuple<Int32, Int32, Int32> availablePowerSupplySize): base(title, price)
        {
            this.AvailablePowerSupplySize = availablePowerSupplySize;
        }
    }
}
