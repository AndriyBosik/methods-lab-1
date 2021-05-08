using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Automation;
using System.Windows.Controls;

using ComputerSalonMVVM.Pages;

namespace ComputerSalonMVVM.ViewModels
{
    class ViewModelLocator
    {
        private ServiceRegister register;

        public ViewModelLocator()
        {
            INavigationService navigationService = new NavigationService();

            register = new ServiceRegister();
            register.Register(navigationService);

            navigationService.Configure(PageType.HomePage, new Uri("../Pages/HomePage.xaml", UriKind.Relative));
            navigationService.Configure(PageType.CollectSystemBlockPage, new Uri("../Pages/CollectSystemBlockPage.xaml", UriKind.Relative));
            navigationService.Configure(PageType.ViewCollectedPage, new Uri("../Pages/ViewCollectedPage.xaml", UriKind.Relative));
            navigationService.Configure(PageType.SaveSystemBlockPage, new Uri("../Pages/SaveSystemBlockPage.xaml", UriKind.Relative));
        }

        public MainViewModel Main
        {
            get => register.ServiceProvider.GetService<MainViewModel>();
        }

    }
}
