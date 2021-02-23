using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PowerSupply : SystemComponentBase
    {
        public Tuple<Int32, Int32, Int32> Size
        { get; set; }

        public Int32 Power
        { get; set; }

        public PowerSupply(string title, Int32 price, Tuple<Int32, Int32, Int32> size, Int32 power): base(title, price)
        {
            this.Size = size;
            this.Power = power;
        }

        public bool HasEnoughPower(IList<IPowerConsumer> consumers)
        {
            var totalPower = 0;
            foreach (var consumer in consumers)
                totalPower += consumer.NeededPower;
            return this.Power >= totalPower;
        }

        public override string ShowInformation()
        {
            return $"Power Supply: {this.Title}(Size: {this.Size.Item1}x{this.Size.Item2}x{this.Size.Item3}; Power: {this.Power}; Price: {this.Price})";
        }
    }
}
