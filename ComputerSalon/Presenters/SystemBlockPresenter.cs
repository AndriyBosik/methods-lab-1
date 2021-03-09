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
        private IComputerService service;

        public SystemBlockPresenter(ISystemBlockView view)
        {
            this.view = view;
            this.service = new ComputerService();

            IComponentsHolder holder = new ComponentsHolder();

            view.UpdateData(holder);
        }

        public void Check()
        {
            SystemBlockHandler handler = new SystemBlockHandler();
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
    }
}
