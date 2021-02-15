using System;

namespace DataAccessLayerEntities
{
    public class PowerSupplyEntity : SystemComponentBaseEntity<PowerSupplyEntity>
    {
        public Tuple<Int32, Int32, Int32> Size
        { get; set; }

        public Int32 Power
        { get; set; }
        public PowerSupplyEntity(string title, Int32 price, Tuple<Int32, Int32, Int32> size, Int32 power): base(title, price)
        {
            this.Size = size;
            this.Power = power;
        }
    }
}
