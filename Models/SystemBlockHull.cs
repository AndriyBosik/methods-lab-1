using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SystemBlockHull: SystemComponentBase
    {
        public Tuple<Int32, Int32, Int32> AvailablePowerSupplySize
        { get; set; }

        public bool CanAccommodatePowerSupply(PowerSupply ps)
        {
            return  ps.Size.Item1 <= this.AvailablePowerSupplySize.Item1 &&
                    ps.Size.Item2 <= this.AvailablePowerSupplySize.Item2 &&
                    ps.Size.Item3 <= this.AvailablePowerSupplySize.Item3;
        }

        public override string ShowInformation()
        {
            return $"System Block Hull {this.Title}(Available Power Supply Size: {this.AvailablePowerSupplySize.Item1}x{this.AvailablePowerSupplySize.Item2}x{this.AvailablePowerSupplySize.Item3}; Price: {this.Price})";
        }

        public override string ToString()
        {
            return ShowInformation();
        }
    }
}
