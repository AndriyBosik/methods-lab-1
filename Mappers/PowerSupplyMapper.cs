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
            return new PowerSupplyEntity(powerSupply.Title, powerSupply.Price, powerSupply.Size, powerSupply.Price);
        }
    }
}
