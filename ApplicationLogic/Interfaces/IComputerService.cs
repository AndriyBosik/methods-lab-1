using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ApplicationLogic.Interfaces
{
    public interface IComputerService
    {
        Task<IList<Processor>> GetProcessorsAsync();

        Task<IList<Motherboard>> GetMotherboardsAsync();

        Task<IList<MemoryCard>> GetMemoryCardsAsync();

        Task<IList<PowerSupply>> GetPowerSuppliersAsync();

        Task<IList<SystemBlockHull>> GetSystemBlockHullsAsync();
    }
}
