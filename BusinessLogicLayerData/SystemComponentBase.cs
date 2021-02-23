using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData.Interfaces;

namespace BusinessLogicLayerData
{
    abstract public class SystemComponentBase
    {
        public string Title
        { get; set; }

        public Int32 Price
        { get; set; }

        public SystemComponentBase(string title, Int32 price)
        {
            this.Title = title;
            this.Price = price;
        }

        public abstract string ShowInformation();
    }
}
