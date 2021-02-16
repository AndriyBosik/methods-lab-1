using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;

namespace BusinessLogicLayer.Containers
{
    class MemoryCardContainer : AbstractContainer<MemoryCard>
    {
     
        public MemoryCardContainer()
        {
            MaxCount = 2;
        }

    }
}
