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
        private CollectedViewModel collectedViewModel;
        private SystemBlockViewModel systemBlockViewModel;

        public INavigationService Navigation
        { get; set; }

        public SystemBlockComponentsViewModel SystemBlockComponentsViewModel
        {
            get => provider.GetService<SystemBlockComponentsViewModel>();
        }

        public HomePageViewModel HomePageViewModel
        {
            get => provider.GetService<HomePageViewModel>();
        }

        public CollectedViewModel CollectedViewModel
        {
            get => provider.GetService<CollectedViewModel>();
        }

        public SystemBlockViewModel SystemBlockViewModel
        {
            get => provider.GetService<SystemBlockViewModel>();
        }

        public MainViewModel(INavigationService navigationService,
                             IServiceProvider provider)
        {
            this.provider = provider;
            Navigation = navigationService;
        }

    }
}
