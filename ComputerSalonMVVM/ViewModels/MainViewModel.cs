using ComputerSalonMVVM.Abstraction;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Windows;

namespace ComputerSalonMVVM.ViewModels
{
    class MainViewModel: ViewModelBase
    {
        private IServiceProvider provider;

        private SystemBlockComponentsViewModel systemBlockComponentsViewModel;
        private HomePageViewModel homePageViewModel;
        private SystemBlockViewModel systemBlockViewModel;

        public INavigationService Navigation
        { get; set; }

        public SystemBlockComponentsViewModel SystemBlockComponentsViewModel
        {
            get => systemBlockComponentsViewModel;
        }

        public HomePageViewModel HomePageViewModel
        {
            get => homePageViewModel;
        }

        public CollectedViewModel CollectedViewModel
        {
            get => provider.GetService<CollectedViewModel>();
        }

        public SystemBlockViewModel SystemBlockViewModel
        {
            get => systemBlockViewModel;
        }

        public MainViewModel(INavigationService navigationService,
                             IServiceProvider provider)
        {
            this.provider = provider;
            Navigation = navigationService;

            systemBlockComponentsViewModel = provider.GetService<SystemBlockComponentsViewModel>();
            homePageViewModel = provider.GetService<HomePageViewModel>();
            systemBlockViewModel = provider.GetService<SystemBlockViewModel>();
        }

    }
}
