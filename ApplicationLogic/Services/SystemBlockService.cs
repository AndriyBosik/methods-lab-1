using ApplicationLogic.Interfaces;

using Models;

using DataAccess;

using Mappers;

namespace ApplicationLogic.Services
{
    public class SystemBlockService : ISystemBlockService
    {
        private UnitOfWork unitOfWork;

        public SystemBlockService()
        {
            unitOfWork = new UnitOfWork();
        }

        public int Save(SystemBlock systemBlock)
        {
            IMapper<Data.SystemBlock, Models.SystemBlock> systemBlockMapper = new SystemBlockMapper();

            Data.SystemBlock entitySystemBlock = systemBlockMapper.MapToEntity(systemBlock);

            unitOfWork.SystemBlockRepository.Create(entitySystemBlock);

            unitOfWork.Save();

            return entitySystemBlock.Id;
        }
    }
}
