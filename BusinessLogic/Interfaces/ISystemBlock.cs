using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Models.Interfaces;

namespace BusinessLogic.Interfaces
{
    public interface ISystemBlock
    {
        Int32 Price
        { get; }

        void AddComponent(SystemComponentBase component);

        bool CanAddOneMore(SystemComponentType componentType);

        bool IsWorking();

        IList<IPowerConsumer> GetPowerConsumers();

        IList<SystemComponentBase> GetComponents(SystemComponentType componentType);
    }
}
