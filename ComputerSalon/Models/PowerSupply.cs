using System;
using System.Collections.Generic;

namespace ComputerSalon.Models
{
    class PowerSupply: Base<PowerSupply>
    {
        // Width, Height, Length
        public readonly Tuple<int, int, int> Size;
        public readonly int Power;
        public PowerSupply(String title, Int32 price, Tuple<int, int, int> size, int power): base(title, price)
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

        public override string ToString()
        {
            return $"Power Supply: {this.Title}(Size: {this.Size.Item1}x{this.Size.Item2}x{this.Size.Item3}; Power: {this.Power}; Price: {this.Price})";
        }
    }
}
