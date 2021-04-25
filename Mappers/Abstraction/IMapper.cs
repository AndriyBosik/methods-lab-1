using System;

namespace Mappers.Abstraction
{
    public interface IMapper<TEntity, TModel>
    {
        TEntity MapToEntity(TModel model);
    }
}
