﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interfaces;

namespace Models
{
    public class Processor: SystemComponentBase, IPowerConsumer
    {
        public Int32 NeededPower
        { get; set; }

        public override string ShowInformation()
        {
            return $"Processor: {this.Title}(Power Consumption: {this.NeededPower}; Price: {this.Price})";
        }

        public override string ToString()
        {
            return ShowInformation();
        }
    }
}
