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
        public IDAO<Int32, MemoryCardEntity> MemoryCardDAO
        { get;  }

        public IDAO<Int32, MotherboardEntity> MotherboardDAO
        { get; }

        public IDAO<Int32, PowerSupplyEntity> PowerSupplyDAO
        { get; }

        public IDAO<Int32, ProcessorEntity> ProcessorDAO
        { get; }

        public IDAO<Int32, SystemBlockHullEntity> SystemBlockHullDAO
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
