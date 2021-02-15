using System;

namespace DataAccessLayer.Entities
{
    class MemoryCardEntity : SystemComponentBaseEntity<MemoryCardEntity>
    {
        public Int32 NeededPower
        { get; set; }

        public MemoryCardEntity(string title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.NeededPower = neededPower;
        }
    }
}
