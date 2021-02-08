using System;
using System.Collections.Generic;

namespace ComputerSalon.Models
{
    class PowerSupply: Base<PowerSupply>
    {
        // Width, Height, Length
        public readonly Tuple<int, int, int> Size;
        public readonly int Power;
        public PowerSupply(Tuple<int, int, int> size, int power)
        {
            this.Size = size;
            this.Power = power;
        }

        public bool HasEnoughtPower(IList<IPowerConsumer> consumers)
        {
            var powerSum = 0;
            foreach (var consumer in consumers)
            {
                powerSum += consumer.GetPowerConsumption();
            }
            return powerSum <= Power;
        }
    }
}
