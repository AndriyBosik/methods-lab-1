using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSalonModels
{
    abstract public class SystemComponentBaseModel
    {
        public string Title
        { get; set; }

        public Int32 Price
        { get; set; }
    }
}
