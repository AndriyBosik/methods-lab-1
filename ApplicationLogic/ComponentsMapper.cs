using System;
using System.Collections.Generic;
using System.Text;

using Data;

using Models;

namespace ApplicationLogic
{
    class ComponentsMapper
    {
        public MemoryCard MemoryCardMapper(Component component)
        {
            MemoryCard model = new MemoryCard();

            return InitWithData(model, component);
        }

        public Motherboard MotherboardMapper(Component component)
        {
            Motherboard model = new Motherboard();

            return InitWithData(model, component);
        }

        public PowerSupply PowerSupplyMapper(Component component)
        {
            PowerSupply model = new PowerSupply();

            return InitWithData(model, component);
        }

        public Processor ProcessorMapper(Component component)
        {
            Processor model = new Processor();

            return InitWithData(model, component);
        }

        public SystemBlockHull SystemBlockHullMapper(Component component)
        {
            SystemBlockHull model = new SystemBlockHull();

            return InitWithData(model, component);
        }

        private T InitWithData<T>(T model, Component component) where T: SystemComponentBase
        {
            model.Id = component.Id;
            model.Title = component.Title;
            model.Price = component.Price;
            model.Type = (ComponentType)component.Group;
            return model;
        }
    }
}
