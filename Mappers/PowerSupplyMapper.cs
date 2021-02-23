using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using DataAccessLayerEntities;

namespace Mappers
{
    public static class PowerSupplyMapper
    {
        public static PowerSupplyEntity ToEntity(this PowerSupply powerSupply)
        {
            return new PowerSupplyEntity
            {
                Title = powerSupply.Title,
                Price = powerSupply.Price,
                Size = powerSupply.Size,
                Power = powerSupply.Power
            };
        }

        public static PowerSupply ToModel(this PowerSupplyEntity powerSupply)
        {
            return new PowerSupply(powerSupply.Title, powerSupply.Price, powerSupply.Size, powerSupply.Power);
        }
    }
}
