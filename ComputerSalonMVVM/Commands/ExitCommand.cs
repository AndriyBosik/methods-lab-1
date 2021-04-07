using System;
using System.Windows;
using System.Windows.Input;

namespace ComputerSalonMVVM.Commands
{
    public class ExitCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            (parameter as Window).Close();
        }
    }
}
