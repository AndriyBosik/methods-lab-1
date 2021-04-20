using System.Linq;

using Data;

using DataAccess;

using Models;

namespace Mappers
{
    public class SystemBlockMapper: IMapper<Data.SystemBlock, Models.SystemBlock>
    {
        private IMapper<SystemBlockComponent, SystemComponentBase> componentMapper;

        public SystemBlockMapper()
        {
            componentMapper = new SystemBlockComponentMapper();
        }

        public Data.SystemBlock MapToEntity(Models.SystemBlock model)
        {
            return new Data.SystemBlock
            {
                Title = model.Title,
                SystemBlockComponents = model.Components.Select(componentMapper.MapToEntity).ToList()
            };
        }

    }
}
