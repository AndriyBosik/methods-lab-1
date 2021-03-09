using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace ApplicationLogic.Handlers
{
    public class SystemComponentTypeHandler
    {
        public ComponentType GetSystemComponentType(Type type)
        {
            if (type == typeof(MemoryCard))
                return ComponentType.MemoryCard;
            if (type == typeof(Motherboard))
                return ComponentType.Motherboard;
            if (type == typeof(PowerSupply))
                return ComponentType.PowerSupply;
            if (type == typeof(Processor))
                return ComponentType.Processor;
            if (type == typeof(SystemBlockHull))
                return ComponentType.SystemBlockHull;
            return ComponentType.SystemBlockHull;
        }

        public ComponentType GetSystemComponentType(SystemComponentBase systemComponent)
        {
            return GetSystemComponentType(systemComponent.GetType());
        }

        public string GetStringRepresentation(ComponentType componentType)
        {
            switch (componentType)
            {
                case ComponentType.Processor:
                    return "Processor";
                case ComponentType.PowerSupply:
                    return "Power Supply";
                case ComponentType.MemoryCard:
                    return "Memory Card";
                case ComponentType.Motherboard:
                    return "Motherboard";
                case ComponentType.SystemBlockHull:
                    return "System Block";
                default:
                    return "System Block";
            }
        }
    }
}
