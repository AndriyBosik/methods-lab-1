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

        bool IsWorking();

        void Clear();

        IList<IPowerConsumer> GetPowerConsumers();

        IContainer GetContainer(ComponentType componentType);
    }
}
