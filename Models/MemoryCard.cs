﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interfaces;

namespace Models
{
    public class MemoryCard: SystemComponentBase, IPowerConsumer
    {
        public Int32 NeededPower
        { get; set; }

        public MemoryCard(string title, Int32 price, Int32 neededPower): base(title, price)
        {
            this.NeededPower = neededPower;
        }

        public override string ShowInformation()
        {
            return $"Memory Card: {this.Title}(Power Consumption: {this.NeededPower}, Price: {this.Price})";
        }
    }
}