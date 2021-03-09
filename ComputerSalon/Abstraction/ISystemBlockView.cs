using System;
using System.Collections.Generic;
using System.Text;

using Models;

using ApplicationLogic.Interfaces;

namespace ComputerSalon.Abstraction
{
    interface ISystemBlockView
    {
        void ShowSuccessMessage(String title, String message);

        void ShowErrorMessage(String title, String message);

        void UpdateData(IComponentsHolder holder);

        int GetComponentSelectedIndex(ComponentType type);

        IList<SystemComponentBase> GetSelectedComponents();
    }
}
