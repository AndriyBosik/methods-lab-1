﻿using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;

using MVVMModels;

using Models;

using ApplicationLogic.Handlers;
using ApplicationLogic.Interfaces;

namespace ComputerSalonMVVM.Commands
{
    public class CheckSystemBlockCommand : ICommand
    {
        private SystemBlockComponents components;
        private SystemBlock systemBlock;
        private ISystemBlockHandler handler;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public CheckSystemBlockCommand(SystemBlock systemBlock, SystemBlockComponents components, ISystemBlockHandler handler)
        {
            this.handler = handler;
            this.systemBlock = systemBlock;
            this.components = components;
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

            if (handler.IsWorking())
            {
                components.Status = $"System Block can be collected. The price is {handler.Price} $";
                foreach (SystemComponentBase component in selectedComponents)
                    systemBlock.Components.Add(component);
            }
            else
                components.Status = "System Block can not be collected";
        }
    }
}
