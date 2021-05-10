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
using ApplicationLogic.Services;
using ApplicationLogic.Containers;
using System.Windows;

namespace ComputerSalonMVVM
{
    public class SystemBlockHandler: ISystemBlockHandler
    {
        private IDictionary<ComponentType, IContainer> components;
        private readonly ITypeService typeService;

        public Double Price
        { get; private set; }

        public SystemBlockHandler(ITypeService typeService)
        {
            this.typeService = typeService;

            components = new Dictionary<ComponentType, IContainer>();
            Clear();
        }

        public void AddComponent(SystemComponentBase component)
        {
            this.Price += component.Price;

            components[component.Type].AddComponent(component);
        }

        public bool IsWorking()
        {
            IValidator containerValidator = new ContainerValidator();
            IValidator sizeValidator = new SizeValidator();
            IValidator powerValidator = new PowerValidator();
            containerValidator.Next = sizeValidator;
            sizeValidator.Next = powerValidator;
            return containerValidator.Validate(this);
        }

        public IList<IPowerConsumer> GetPowerConsumers()
        {
            IList<IPowerConsumer> consumers = new List<IPowerConsumer>();
            foreach (var container in components.Values)
                consumers = consumers.Concat(GetConsumersFromContainer(container)).ToList();
            return consumers;
        }

        public IContainer GetContainer(ComponentType componentType)
        {
            return components[componentType];
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

        public void Clear()
        {
            this.Price = 0;

            foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
                if (components.ContainsKey(componentType))
                    components[componentType] = new ComponentsContainer(componentType, typeService);
                else
                    components.Add(componentType, new ComponentsContainer(componentType, typeService));
        }
    }
}
