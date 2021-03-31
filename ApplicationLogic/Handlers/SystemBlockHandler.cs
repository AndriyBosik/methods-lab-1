using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApplicationLogic;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Factories;
using ApplicationLogic.Validators;

using Models;
using Models.Interfaces;

namespace ApplicationLogic.Handlers
{
    public class SystemBlockHandler: ISystemBlockHandler
    {
        private IDictionary<ComponentType, IContainer> components;

        public Double Price
        { get; private set; }

        public SystemBlockHandler()
        {
            components = new Dictionary<ComponentType, IContainer>();
            InitDictionary();
        }

        public void AddComponent(SystemComponentBase component)
        {
            this.Price += component.Price;

            components[component.Type].AddComponent(component);
        }

        public bool CanAddOneMore(SystemComponentBase component)
        {
            return components[component.Type].CanAddOneMoreComponent();
        }

        public bool IsWorking()
        {
            IValidator countValidator = new CountValidator();
            IValidator sizeValidator = new SizeValidator();
            IValidator powerValidator = new PowerValidator();
            countValidator.Next = sizeValidator;
            sizeValidator.Next = powerValidator;
            return countValidator.Validate(this);
        }

        public IList<IPowerConsumer> GetPowerConsumers()
        {
            IList<IPowerConsumer> consumers = new List<IPowerConsumer>();
            foreach (var container in components.Values)
                consumers = consumers.Concat(GetConsumersFromContainer(container)).ToList();
            return consumers;
        }

        public IList<SystemComponentBase> GetComponents(ComponentType componentType)
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
            foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
                components.Add(componentType, ContainerFactory.GetContainer(componentType));
        }
    }
}
