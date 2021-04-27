using ApplicationLogic.Interfaces;

using DataAccess.Abstraction;

using Mappers;
using Mappers.Abstraction;

namespace ApplicationLogic.Services
{
    public class SystemBlockService : ISystemBlockService
    {
        private IUnitOfWork unitOfWork;

        public SystemBlockService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Save(Models.SystemBlock systemBlock)
        {
            IMapper<Data.SystemBlock, Models.SystemBlock> systemBlockMapper = new SystemBlockMapper();

            unitOfWork.SystemBlockRepository.Create(systemBlockMapper.MapToEntity(systemBlock));
            unitOfWork.Save();
        }
    }
}
