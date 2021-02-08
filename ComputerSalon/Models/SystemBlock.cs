using System.Collections.Generic;

namespace ComputerSalon.Models
{
    class SystemBlock
    {
        private SystemBlockHull systemBlockHull;
        private PowerSupply powerSupply;
        private MemoryCard memoryCard;
        private Motherboard motherboard;
        private Processor processor;

        public SystemBlock(SystemBlockHull sbh, PowerSupply ps, MemoryCard mc, Motherboard m, Processor p)
        {
            this.systemBlockHull = sbh;
            this.powerSupply = ps;
            this.memoryCard = mc;
            this.motherboard = m;
            this.processor = p;
        }

        public bool IsWorking()
        {
            return  this.systemBlockHull.CanAccommodatePowerSupply(this.powerSupply) &&
                    this.powerSupply.HasEnoughtPower(new List<IPowerConsumer>
                    {
                        this.memoryCard, this.motherboard, this.processor
                    });
        }

    }
}
