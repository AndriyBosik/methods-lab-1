using ComputerSalonMVVM.Abstraction;
using System;
using System.Windows;
using System.Windows.Input;

namespace ComputerSalonMVVM.Commands
{
    class GoBackCommand : ICommand
    {
        private INavigationService navigation;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public GoBackCommand(INavigationService navigation)
        {
            this.navigation = navigation;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            navigation.GoBack();
        }
    }
}
