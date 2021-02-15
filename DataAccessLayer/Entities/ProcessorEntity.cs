using System;

namespace DataAccessLayer.Entities
{
    class ProcessorEntity: SystemComponentBaseEntity<ProcessorEntity>
    {
        public Int32 NeededPower
        { get; set; }
        public ProcessorEntity(string title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.NeededPower = neededPower;
        }
    }
}
