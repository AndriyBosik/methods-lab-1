using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class Processor: Base<Processor>, IPowerConsumer
    {
        private int neededPower;
        public Processor(int neededPower)
        {
            this.neededPower = neededPower;
        }

        public int GetPowerConsumption()
        {
            return this.neededPower;
        }

    }
}
