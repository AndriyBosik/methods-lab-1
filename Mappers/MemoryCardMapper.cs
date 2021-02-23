using BusinessLogicLayerData;
using DataAccessLayerEntities;

namespace Mappers
{
    public static class MemoryCardMapper
    {
        public static MemoryCardEntity ToEntity(this MemoryCard memoryCard)
        {
            return new MemoryCardEntity
            {
                Title = memoryCard.Title,
                Price = memoryCard.Price,
                NeededPower = memoryCard.NeededPower
            };
        }

        public static MemoryCard ToModel(this MemoryCardEntity memoryCard)
        {
            return new MemoryCard(memoryCard.Title, memoryCard.Price, memoryCard.NeededPower);
        }
    }
}
