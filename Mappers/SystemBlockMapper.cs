using System;
using System.Collections.Generic;
using System.Text;

using Data;

using DataAccess;

using Models;

namespace Mappers
{
    public class SystemBlockMapper: IMapper<Data.SystemBlock, Models.SystemBlock>
    {
        public Data.SystemBlock MapToEntity(Models.SystemBlock model)
        {
            return new Data.SystemBlock
            {
                Title = model.Title
            };
        }

    }
}
