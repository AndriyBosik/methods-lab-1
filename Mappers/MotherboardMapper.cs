using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Entities;

namespace Mappers
{
    public static class MotherboardMapper
    {
        public static MotherboardEntity ToEntity(this Motherboard motherboard)
        {
            return new MotherboardEntity
            {
                Title = motherboard.Title,
                Price = motherboard.Price,
                NeededPower = motherboard.NeededPower
            };
        }

        public static Motherboard ToModel(this MotherboardEntity motherboard)
        {
            return new Motherboard(motherboard.Title, motherboard.Price, motherboard.NeededPower);
        }
    }
}
