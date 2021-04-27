using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace ApplicationLogic.Interfaces
{
    public interface IContainer
    {
        void AddComponent(SystemComponentBase systemComponent);

        Boolean IsValid();

        IList<SystemComponentBase> GetItems();

    }
}
