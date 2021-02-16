﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData.Interfaces;

namespace BusinessLogicLayerData
{
    public class Processor: SystemComponentBase, IPowerConsumer
    {
        public Int32 NeededPower
        { get; set; }

        public Processor(string title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.NeededPower = neededPower;
        }

        public override string ToString()
        {
            return $"Processor: {this.Title}(Power Consumption: {this.NeededPower}; Price: {this.Price})";
        }
    }
}
