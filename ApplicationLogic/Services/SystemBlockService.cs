using ApplicationLogic.Interfaces;

using DataAccess;

using Mappers;
using Mappers.Abstraction;

namespace ApplicationLogic.Services
{
    public class SystemBlockService : ISystemBlockService
    {
        private UnitOfWork unitOfWork;

        public SystemBlockService()
        {
            unitOfWork = new UnitOfWork();
        }

        public void Save(Models.SystemBlock systemBlock)
        {
            IMapper<Data.SystemBlock, Models.SystemBlock> systemBlockMapper = new SystemBlockMapper();

            unitOfWork.SystemBlockRepository.Create(systemBlockMapper.MapToEntity(systemBlock));
            unitOfWork.Save();
        }
    }
}
