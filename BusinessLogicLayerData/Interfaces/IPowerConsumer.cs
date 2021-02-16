using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerData.Interfaces
{
    public interface IPowerConsumer
    {
        Int32 NeededPower
        { get; set; }
    }
}
