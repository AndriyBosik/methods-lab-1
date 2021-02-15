using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerData
{
    public class SystemBlockHull: SystemComponentBase
    {
        public Tuple<Int32, Int32, Int32> AvailablePowerSupplySize
        { get; set; }
    }
}
