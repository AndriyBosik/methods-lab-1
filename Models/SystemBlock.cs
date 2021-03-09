using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SystemBlock
    {
        public MemoryCard MemoryCard
        { get; set; }

        public Motherboard Motherboard
        { get; set; }

        public PowerSupply PowerSupply
        { get; set; }

        public Processor Processor
        { get; set; }

        public SystemBlockHull SystemBlockHull
        { get; set; }
    }
}
