using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;

namespace Salon.Interfaces
{
    interface IDataReader
    {
        MemoryCard GetMemoryCard();

        Motherboard GetMotherboard();

        PowerSupply GetPowerSupply();

        Processor GetProcessor();

        SystemBlockHull GetSystemBlockHull();
    }
}
