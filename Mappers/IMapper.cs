using System;

namespace Mappers
{
    public interface IMapper<TEntity, TModel>
    {
        TEntity MapToEntity(TModel model);
    }
}
