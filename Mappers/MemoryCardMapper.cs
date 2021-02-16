using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using DataAccessLayerEntities;

namespace Mappers
{
    public static class MemoryCardMapper
    {
        public static MemoryCardEntity ToEntity(this MemoryCard memoryCard)
        {
            return new MemoryCardEntity(memoryCard.Title, memoryCard.Price, memoryCard.NeededPower);
        }

        public static MemoryCard ToModel(this MemoryCardEntity memoryCard)
        {
            return new MemoryCard(memoryCard.Title, memoryCard.Price, memoryCard.NeededPower);
        }
    }
}
