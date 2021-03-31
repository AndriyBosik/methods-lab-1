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
    class SystemBlockPresenter
    {
        private ISystemBlockView view;

        public SystemBlockPresenter(ISystemBlockView view)
        {
            this.view = view;

            this.view.ViewLoaded += DisplayData;
            this.view.QuitButtonClicked += FinishApp;
            this.view.CheckButtonClicked += Check;
        }

        private void DisplayData()
        {
            IComponentsHolder holder = new ComponentsHolder();

            view.ShowComponents(holder.MemoryCards);
            view.ShowComponents(holder.Motherboards);
            view.ShowComponents(holder.PowerSuppliers);
            view.ShowComponents(holder.Processors);
            view.ShowComponents(holder.SystemBlockHulls);
        }

        private void Check()
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

        private void FinishApp()
        {
            view.Shutdown();
        }
    }
}
