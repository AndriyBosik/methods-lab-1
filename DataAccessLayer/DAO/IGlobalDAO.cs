using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerEntities;

namespace DataAccessLayer.DAO
{
    public interface IGlobalDAO
    {
        IDAO<Int32, MemoryCardEntity> MemoryCardDAO
        { get; }

        IDAO<Int32, MotherboardEntity> MotherboardDAO
        { get; }

        IDAO<Int32, PowerSupplyEntity> PowerSupplyDAO
        { get; }

        IDAO<Int32, ProcessorEntity> ProcessorDAO
        { get; }

        IDAO<Int32, SystemBlockHullEntity> SystemBlockHullDAO
        { get; }
    }
}
