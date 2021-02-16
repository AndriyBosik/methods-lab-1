using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;

namespace BusinessLogicLayer
{
    static class SystemComponentTypeHandler
    {
        public static SystemComponentType GetSystemComponentType(SystemComponentBase systemComponent)
        {
            if (systemComponent.GetType() == typeof(MemoryCard))
                return SystemComponentType.MemoryCard;
            if (systemComponent.GetType() == typeof(Motherboard))
                return SystemComponentType.Motherboard;
            if (systemComponent.GetType() == typeof(PowerSupply))
                return SystemComponentType.PowerSupply;
            if (systemComponent.GetType() == typeof(Processor))
                return SystemComponentType.Processor;
            if (systemComponent.GetType() == typeof(SystemBlockHull))
                return SystemComponentType.SystemBlockHull;
            return SystemComponentType.SystemBlockHull;
        }
    }
}
