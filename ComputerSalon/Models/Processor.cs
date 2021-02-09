﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSalon.Models
{
    class Processor: Base<Processor>, IPowerConsumer
    {
        private Int32 neededPower;
        public Processor(string title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.neededPower = neededPower;
        }

        public Int32 GetPowerConsumption()
        {
            return this.neededPower;
        }

        public override string ToString()
        {
            return $"Processor: {this.Title}(Power Consumption: {this.neededPower}; Price: {this.Price})";
        }

    }
}
