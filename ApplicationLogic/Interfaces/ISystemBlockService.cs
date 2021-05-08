using System;
using System.Collections.Generic;
using System.Text;

using Models;

namespace ApplicationLogic.Interfaces
{
    public interface ISystemBlockService
    {
        public void Save(SystemBlock systemBlock);

        public IList<SystemBlock> GetSystemBlocks();
    }
}
