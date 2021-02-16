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
        IDAO<MemoryCardEntity> MemoryCardDAO
        { get; }

        IDAO<MotherboardEntity> MotherboardDAO
        { get; }

        IDAO<PowerSupplyEntity> PowerSupplyDAO
        { get; }

        IDAO<ProcessorEntity> ProcessorDAO
        { get; }

        IDAO<SystemBlockHullEntity> SystemBlockHullDAO
        { get; }
    }
}
