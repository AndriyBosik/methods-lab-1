using Data;

using Models;

using Mappers.Abstraction;

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
