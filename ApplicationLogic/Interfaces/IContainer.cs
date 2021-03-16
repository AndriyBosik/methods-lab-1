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
        Boolean IsMultiply
        { get; }

        void AddComponent(SystemComponentBase systemComponent);

        bool CanAddOneMoreComponent();

        IList<SystemComponentBase> GetItems();

    }
}
