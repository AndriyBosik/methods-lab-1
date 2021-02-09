using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class MemoryCard: Base<MemoryCard>, IPowerConsumer
    {
        private Int32 neededPower;

        public MemoryCard(String title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.neededPower = neededPower;
        }

        public Int32 GetPowerConsumption()
        {
            return this.neededPower;
        }

        public override string ToString()
        {
            return $"Memory Card: {this.Title}(Power Consumption: {this.neededPower}, Price: {this.Price})";
        }
    }
}
