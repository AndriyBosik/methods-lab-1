using System;
using System.Collections.Generic;

using ApplicationLogic;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;

using Models;

using ComputerSalon.Abstraction;
using ApplicationLogic.Handlers;

namespace ComputerSalon.Presenters
{
    class SystemBlockPresenter: ISystemBlockPresenter
    {
        private ISystemBlockView view;

        public SystemBlockPresenter(ISystemBlockView view)
        {
            this.view = view;

            IComponentsHolder holder = new ComponentsHolder();

            view.ShowComponents(holder.MemoryCards);
            view.ShowComponents(holder.Motherboards);
            view.ShowComponents(holder.PowerSuppliers);
            view.ShowComponents(holder.Processors);
            view.ShowComponents(holder.SystemBlockHulls);
        }

        public void Check()
        {
            ISystemBlockHandler handler = new SystemBlockHandler();
            IList<SystemComponentBase> components = view.GetSelectedComponents();

            foreach (SystemComponentBase component in components)
            {
                if (!handler.CanAddOneMore(component))
                {
                    view.ShowErrorMessage("Error", "Unable to add " + component.Title);
                    return;
                }
                else
                {
                    handler.AddComponent(component);
                }
            }
            if (handler.IsWorking())
                view.ShowSuccessMessage("Success", "System Block was successfully collected! The price is: " + handler.Price + "$");
            else
                view.ShowErrorMessage("Error", "Unfortunatelly, system block can not be collected");
        }

        public void FinishApp()
        {
            view.Shutdown();
        }
    }
}
