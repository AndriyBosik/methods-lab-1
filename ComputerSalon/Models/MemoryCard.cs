using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class MemoryCard: Base<MemoryCard>, IPowerConsumer
    {
        private int neededPower;

        public MemoryCard(int neededPower)
        {
            this.neededPower = neededPower;
        }

        public int GetPowerConsumption()
        {
            return this.neededPower;
        }
    }
}
