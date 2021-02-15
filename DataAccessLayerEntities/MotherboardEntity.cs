using System;

namespace DataAccessLayerEntities
{
    public class MotherboardEntity : SystemComponentBaseEntity<MotherboardEntity>
    {
        public Int32 NeedePower
        { get; set; }
        public MotherboardEntity(string title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.NeedePower = neededPower;
        }
    }
}
