using Data;

using Models;

namespace Mappers
{
    class SystemBlockComponentMapper : IMapper<SystemBlockComponent, SystemComponentBase>
    {
        public SystemBlockComponent MapToEntity(SystemComponentBase model)
        {
            return new SystemBlockComponent
            {
                ComponentId = model.Id
            };
        }
    }
}
