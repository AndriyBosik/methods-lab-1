using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Models.Interfaces;

namespace ApplicationLogic.Interfaces
{
    public interface ISystemBlockHandler
    {
        Double Price
        { get; }

        void AddComponent(SystemComponentBase component);

        bool CanAddOneMore(SystemComponentBase component);

        bool IsWorking();

        IList<IPowerConsumer> GetPowerConsumers();

        IList<SystemComponentBase> GetComponents(ComponentType componentType);
    }
}
