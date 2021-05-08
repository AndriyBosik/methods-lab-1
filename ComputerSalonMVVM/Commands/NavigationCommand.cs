using ComputerSalonMVVM.Abstraction;
using System;
using System.Windows.Input;

using ComputerSalonMVVM.Pages;

namespace ComputerSalonMVVM.Commands
{
    class NavigationCommand: ICommand
    {
        private INavigationService navigation;
        private PageType pageType;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public NavigationCommand(INavigationService navigation, PageType pageType)
        {
            this.navigation = navigation;
            this.pageType = pageType;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.navigation.NavigateTo(this.pageType);
        }
    }
}
