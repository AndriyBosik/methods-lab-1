using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class SystemBlockHull: Base<SystemBlockHull>
    {
        // Width, Height, Length
        public readonly Tuple<int, int, int> AvailablePowerSupplySize;

        public SystemBlockHull(Tuple<int, int, int> availablePowerSupplySize)
        {
            this.AvailablePowerSupplySize = availablePowerSupplySize;
        }

        public bool CanAccommodatePowerSupply(PowerSupply ps)
        {
            return  ps.Size.Item1 <= this.AvailablePowerSupplySize.Item1 &&
                    ps.Size.Item2 <= this.AvailablePowerSupplySize.Item2 &&
                    ps.Size.Item3 <= this.AvailablePowerSupplySize.Item3;
        }
    }
}
