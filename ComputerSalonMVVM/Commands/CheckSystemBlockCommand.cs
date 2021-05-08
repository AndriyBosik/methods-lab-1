using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;

using MVVMModels;

using Models;

using ApplicationLogic.Interfaces;

using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.Pages;
using System.Windows;

namespace ComputerSalonMVVM.Commands
{
    class CheckSystemBlockCommand : ICommand
    {
        private SystemBlockComponents components;
        private SystemBlock systemBlock;
        private ISystemBlockHandler handler;
        private INavigationService navigation;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public CheckSystemBlockCommand(SystemBlock systemBlock, SystemBlockComponents components, ISystemBlockHandler handler, INavigationService navigation)
        {
            this.handler = handler;
            this.systemBlock = systemBlock;
            this.components = components;
            this.navigation = navigation;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            systemBlock.Components.Clear();
            handler.Clear();

            IList<SystemComponentBase> selectedComponents = this.components.Components.Values
                .SelectMany(item => item.ToList())
                .Where(item => item.IsSelected)
                .ToList();

            foreach (SystemComponentBase component in selectedComponents)
                handler.AddComponent(component);

            if (handler.IsWorking() && !String.IsNullOrEmpty(systemBlock.Title))
            {
                foreach (SystemComponentBase component in selectedComponents)
                    systemBlock.Components.Add(component);
                navigation.NavigateTo(PageType.SaveSystemBlockPage, systemBlock);
            }
            else
            {
                components.Status = "System Block can not be collected";
            }
        }
    }
}
