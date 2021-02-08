using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class Motherboard: Base<Motherboard>, IPowerConsumer
    {
        private int neededPower;
        public Motherboard(int neededPower)
        {
            this.neededPower = neededPower;
        }

        public int GetPowerConsumption()
        {
            return this.neededPower;
        }

    }
}
