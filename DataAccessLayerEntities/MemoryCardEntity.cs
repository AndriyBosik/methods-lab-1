﻿using System;

namespace DataAccessLayerEntities
{
    public class MemoryCardEntity : SystemComponentBaseEntity<Int32, MemoryCardEntity>
    {
        public Int32 NeededPower
        { get; set; }

    }
}
