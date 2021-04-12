using System;
using System.Collections.Generic;
using System.Text;

using Models;

namespace ApplicationLogic.Interfaces
{
    public interface ISystemBlockService
    {
        int Save(SystemBlock systemBlock);
    }
}
