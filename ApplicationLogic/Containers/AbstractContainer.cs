using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;
using ApplicationLogic.Handlers;

using Models;

namespace ApplicationLogic.Containers
{
    abstract class AbstractContainer<T> : IContainer where T : SystemComponentBase
    {
        private IList<T> components;

        private readonly TypeService typeService;

        public bool IsMultiply
        { 
            get
            {
                if (components.Count > 0)
                    return typeService.IsMultiply(components[0].Type);
                return false;
            }
        }

        public AbstractContainer()
        {
            typeService = new TypeService();
            
            components = new List<T>();
        }
        
        public void AddComponent(SystemComponentBase systemComponent)
        {
            components.Add((T)systemComponent);
        }

        public bool CanAddOneMoreComponent()
        {
            if (IsMultiply)
                return components.Count < 2;
            return components.Count < 1;
        }

        public IList<SystemComponentBase> GetItems()
        {
            return components.Select(component => component as SystemComponentBase).ToList();
        }

    }
}
