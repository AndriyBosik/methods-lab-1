using System;
using System.Windows.Input;

using Models;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;
using System.Windows;

namespace ComputerSalonMVVM.Commands
{
    class SaveSystemBlockCommand: ICommand
    {
        private SystemBlock systemBlock;
        private ISystemBlockService service;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SaveSystemBlockCommand(SystemBlock systemBlock, ISystemBlockService service)
        {
            this.service = service;

            this.systemBlock = systemBlock;
        }

        public bool CanExecute(object parameter)
        {
            return this.systemBlock != null && this.systemBlock.Components.Count > 0 && !String.IsNullOrEmpty(this.systemBlock.Title);
        }

        public void Execute(object parameter)
        {
            service.Save(systemBlock);

            MessageBox.Show("System block was successfully added to database", "Message");
        }
    }
}
