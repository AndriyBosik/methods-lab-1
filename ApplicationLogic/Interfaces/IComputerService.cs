using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ApplicationLogic.Interfaces
{
    public interface IComputerService
    {
        Task<IList<Processor>> GetProcessors();

        Task<IList<Motherboard>> GetMotherboards();

        Task<IList<MemoryCard>> GetMemoryCards();

        Task<IList<PowerSupply>> GetPowerSuppliers();

        Task<IList<SystemBlockHull>> GetSystemBlockHulls();
    }
}
