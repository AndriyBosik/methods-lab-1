using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayer.Interfaces;
using BusinessLogicLayerData;

namespace BusinessLogicLayer.Containers
{
    class AbstractContainer<T> : IContainer where T : SystemComponentBase
    {
        private IList<T> components;

        public int MaxCount { get; set; }

        public AbstractContainer()
        {
            MaxCount = 1;
            components = new List<T>();
        }
        
        public void AddComponent(SystemComponentBase systemComponent)
        {
            components.Add((T)systemComponent);
        }

        public bool CanAddOneMoreComponent()
        {
            return components.Count() < MaxCount;
        }

        public IList<SystemComponentBase> GetItems()
        {
            return components.Select(component => component as SystemComponentBase).ToList();
        }

        public void Print()
        {
            foreach (var component in components)
            {
                Console.WriteLine(component.Title);
            }
            Console.WriteLine("-----------------");
        }
    }
}
