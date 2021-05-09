using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;
using ApplicationLogic.Handlers;

using Models;
using System.Threading.Tasks;

namespace ApplicationLogic.Containers
{
    class ComponentsContainer: IContainer
    {
        private IList<SystemComponentBase> components;
        private ITypeService typeService;
        private Boolean hasError;
        private readonly ComponentType componentType;
        private Boolean isMultiply;

        public ComponentsContainer(ComponentType componentType, ITypeService typeService)
        {
            this.componentType = componentType;
            this.typeService = typeService;

            CheckIfMultiply();

            hasError = false;
            components = new List<SystemComponentBase>();
        }
        
        public void AddComponent(SystemComponentBase systemComponent)
        {
            components.Add(systemComponent);
            if ((isMultiply && components.Count > 2) || (!isMultiply && components.Count > 1) || systemComponent.Type != componentType)
                hasError = true;
        }

        public Boolean IsValid()
        {
            return !hasError && components.Count > 0;
        }

        public IList<SystemComponentBase> GetItems()
        {
            return components.Select(component => component as SystemComponentBase).ToList();
        }

        private async Task CheckIfMultiply()
        {
            isMultiply = await typeService.IsMultiply(componentType);
        }

    }
}
