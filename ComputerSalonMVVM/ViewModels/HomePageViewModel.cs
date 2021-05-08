using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.Commands;
using ComputerSalonMVVM.Pages;

namespace ComputerSalonMVVM.ViewModels
{
    class HomePageViewModel: ViewModelBase
    {
        private ICommand showCollectSystemBlockPageCommand;
        private ICommand showCollectedPageCommand;

        public ICommand ShowCollectSystemBlockPageCommand
        {
            get => showCollectSystemBlockPageCommand;
        }

        public ICommand ShowCollectedPageCommand
        {
            get => showCollectedPageCommand;
        }

        public HomePageViewModel(INavigationService navigationService)
        {
            showCollectSystemBlockPageCommand = new NavigationCommand(navigationService, PageType.CollectSystemBlockPage);
            showCollectedPageCommand = new NavigationCommand(navigationService, PageType.ViewCollectedPage);
        }
    }
}
