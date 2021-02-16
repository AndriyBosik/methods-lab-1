using DataAccessLayerEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAO
{
    public class GlobalDAO : IGlobalDAO
    {
        public IDAO<MemoryCardEntity> MemoryCardDAO
        { get;  }

        public IDAO<MotherboardEntity> MotherboardDAO
        { get; }

        public IDAO<PowerSupplyEntity> PowerSupplyDAO
        { get; }

        public IDAO<ProcessorEntity> ProcessorDAO
        { get; }

        public IDAO<SystemBlockHullEntity> SystemBlockHullDAO
        { get; }

        public GlobalDAO()
        {
            MemoryCardDAO = new MemoryCardDAO();
            MotherboardDAO = new MotherboardDAO();
            PowerSupplyDAO = new PowerSupplyDAO();
            ProcessorDAO = new ProcessorDAO();
            SystemBlockHullDAO = new SystemBlockHullDAO();
        }
    }
}
