using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ApplicationLogic.Interfaces
{
    public interface ISystemBlockService
    {
        public void Save(SystemBlock systemBlock);

        public Task<IList<SystemBlock>> GetSystemBlocks();
    }
}
