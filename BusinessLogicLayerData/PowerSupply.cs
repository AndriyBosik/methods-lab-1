using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerData
{
    public class PowerSupply : SystemComponentBase
    {
        public Tuple<Int32, Int32, Int32> Size
        { get; set; }

        public Int32 Power
        { get; set; }
    }
}
