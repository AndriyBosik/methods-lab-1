using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSalonModels
{
    public class PowerSupplyModel : SystemComponentBaseModel
    {
        public Tuple<Int32, Int32, Int32> Size
        { get; set; }

        public Int32 Power
        { get; set; }
    }
}
