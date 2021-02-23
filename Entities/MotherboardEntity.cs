using System;

namespace Entities
{
    public class MotherboardEntity : SystemComponentBaseEntity<Int32, MotherboardEntity>
    {
        public Int32 NeededPower
        { get; set; }
    }
}
