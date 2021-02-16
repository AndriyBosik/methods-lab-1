using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;
using BusinessLogicLayerData.Interfaces;

namespace BusinessLogicLayer.Interfaces
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
