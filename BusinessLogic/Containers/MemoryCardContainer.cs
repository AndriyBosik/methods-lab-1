﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace BusinessLogic.Containers
{
    class MemoryCardContainer : AbstractContainer<MemoryCard>
    {
     
        public MemoryCardContainer()
        {
            MaxCount = 2;
        }

    }
}
