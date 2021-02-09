using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class SystemBlockHull: Base<SystemBlockHull>
    {
        // Width, Height, Length
        public readonly Tuple<Int32, Int32, Int32> AvailablePowerSupplySize;

        public SystemBlockHull(String title, Int32 price, Tuple<int, int, int> availablePowerSupplySize): base(title, price)
        {
            this.AvailablePowerSupplySize = availablePowerSupplySize;
        }

        public bool CanAccommodatePowerSupply(PowerSupply ps)
        {
            return  ps.Size.Item1 <= this.AvailablePowerSupplySize.Item1 &&
                    ps.Size.Item2 <= this.AvailablePowerSupplySize.Item2 &&
                    ps.Size.Item3 <= this.AvailablePowerSupplySize.Item3;
        }

        public override string ToString()
        {
            return $"System Block Hull {this.Title}(Available Power Supply Size: {this.AvailablePowerSupplySize.Item1}x{this.AvailablePowerSupplySize.Item2}x{this.AvailablePowerSupplySize.Item3}; Price: {this.Price})";
        }
    }
}
