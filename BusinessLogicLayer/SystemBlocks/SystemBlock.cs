using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Factories;
using BusinessLogicLayer.Validators;

using BusinessLogicLayerData;
using BusinessLogicLayerData.Interfaces;

namespace BusinessLogicLayer.SystemBlocks
{
    public class SystemBlock: ISystemBlock
    {
        private IDictionary<SystemComponentType, IContainer> components;

        public Int32 Price
        { get; private set; }

        public SystemBlock()
        {
            components = new Dictionary<SystemComponentType, IContainer>();
            InitDictionary();
        }

        public void AddComponent(SystemComponentBase component)
        {
            this.Price += component.Price;

            var componentType = SystemComponentTypeHandler.GetSystemComponentType(component);

            components[componentType].AddComponent(component);
        }

        public bool CanAddOneMore(SystemComponentType componentType)
        {
            return components[componentType].CanAddOneMoreComponent();
        }

        public bool IsWorking()
        {
            IValidator sizeValidator = new SizeValidator();
            IValidator powerValidator = new PowerValidator();
            sizeValidator.Next = powerValidator;
            return sizeValidator.Validate(this);
        }

        public IList<IPowerConsumer> GetPowerConsumers()
        {
            IList<IPowerConsumer> consumers = new List<IPowerConsumer>();
            foreach (var container in components.Values)
                consumers = consumers.Concat(GetConsumersFromContainer(container)).ToList();
            return consumers;
        }

        public IList<SystemComponentBase> GetComponents(SystemComponentType componentType)
        {
            return components[componentType].GetItems();
        }

        private IList<IPowerConsumer> GetConsumersFromContainer(IContainer container)
        {
            var items = container.GetItems();

            IList<IPowerConsumer> consumers = new List<IPowerConsumer>();
            foreach (var item in items)
                if (item is IPowerConsumer)
                    consumers.Add((IPowerConsumer) item);
            
            return consumers;
        }

        private void InitDictionary()
        {
            foreach (SystemComponentType componentType in Enum.GetValues(typeof(SystemComponentType)))
                components.Add(componentType, ContainerFactory.GetContainer(componentType));
        }
    }
}
