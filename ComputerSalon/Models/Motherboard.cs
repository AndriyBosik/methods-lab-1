using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class Motherboard: Base<Motherboard>, IPowerConsumer
    {
        private Int32 neededPower;
        public Motherboard(String title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.neededPower = neededPower;
        }

        public int GetPowerConsumption()
        {
            return this.neededPower;
        }

        public override string ToString()
        {
            return $"Motherboard: {this.Title}(Power Consumption: {this.neededPower}; Price: {this.Price})";
        }

    }
}
