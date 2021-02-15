using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using DataAccessLayerEntities;

namespace Mappers
{
    public static class MotherboardMapper
    {
        public static MotherboardEntity ToEntity(this Motherboard motherboard)
        {
            return new MotherboardEntity(motherboard.Title, motherboard.Price, motherboard.NeededPower);
        }
    }
}
