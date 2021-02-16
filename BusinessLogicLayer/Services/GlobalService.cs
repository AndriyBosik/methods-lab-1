using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.DAO;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayerData;

namespace BusinessLogicLayer.Services
{
    public class GlobalService : IGlobalService
    {
        public IService<MemoryCard> MemoryCardService
        { get; }

        public IService<Motherboard> MotherboardService
        { get; }

        public IService<PowerSupply> PowerSupplyService
        { get; }

        public IService<Processor> ProcessorService
        { get; }

        public IService<SystemBlockHull> SystemBlockHullService
        { get; }

        public GlobalService(IGlobalDAO globalDAO)
        {
            MemoryCardService = new MemoryCardService(globalDAO.MemoryCardDAO);
            MotherboardService = new MotherboardService(globalDAO.MotherboardDAO);
            PowerSupplyService = new PowerSupplyService(globalDAO.PowerSupplyDAO);
            ProcessorService = new ProcessorService(globalDAO.ProcessorDAO);
            SystemBlockHullService = new SystemBlockHullService(globalDAO.SystemBlockHullDAO);
        }
    }
}
