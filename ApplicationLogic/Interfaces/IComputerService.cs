using System;
using System.Collections.Generic;
using System.Text;

using Models;

namespace ApplicationLogic.Interfaces
{
    public interface IComputerService
    {
        IList<Processor> GetProcessors();

        IList<Motherboard> GetMotherboards();

        IList<MemoryCard> GetMemoryCards();

        IList<PowerSupply> GetPowerSuppliers();

        IList<SystemBlockHull> GetSystemBlockHulls();
    }
}
