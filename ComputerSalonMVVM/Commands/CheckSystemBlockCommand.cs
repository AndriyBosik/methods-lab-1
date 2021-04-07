using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

using MVVMModels;

using Models;

using ApplicationLogic.Handlers;

namespace ComputerSalonMVVM.Commands
{
    public class CheckSystemBlockCommand : ICommand
    {
        private SystemBlockComponents components;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public CheckSystemBlockCommand(SystemBlockComponents components)
        {
            this.components = components;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SystemBlockHandler handler = new SystemBlockHandler();

            this.components.Components.Values
                .SelectMany(item => item.ToList())
                .Where(item => item.IsSelected)
                .ToList()
                .ForEach(item => handler.AddComponent(item));

            if (handler.IsWorking())
                components.Status = $"System Block can be collected. The price is {handler.Price} $";
            else
                components.Status = "System Block can not be collected";
        }
    }
}
