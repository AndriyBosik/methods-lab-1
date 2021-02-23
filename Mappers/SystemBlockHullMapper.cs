using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using DataAccessLayerEntities;

namespace Mappers
{
    public static class SystemBlockHullMapper
    {
        public static SystemBlockHullEntity ToEntity(this SystemBlockHull systemBlockHull)
        {
            return new SystemBlockHullEntity
            {
                Title = systemBlockHull.Title,
                Price = systemBlockHull.Price,
                AvailablePowerSupplySize = systemBlockHull.AvailablePowerSupplySize
            };
        }

        public static SystemBlockHull ToModel(this SystemBlockHullEntity systemBlockHull)
        {
            return new SystemBlockHull(systemBlockHull.Title, systemBlockHull.Price, systemBlockHull.AvailablePowerSupplySize);
        }
    }
}
