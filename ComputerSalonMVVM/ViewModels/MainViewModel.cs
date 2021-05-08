using ComputerSalonMVVM.Abstraction;

namespace ComputerSalonMVVM.ViewModels
{
    class MainViewModel: ViewModelBase
    {
        private SystemBlockComponentsViewModel systemBlockComponentsViewModel;
        private HomePageViewModel homePageViewModel;
        private CollectedViewModel collectedViewModel;
        private SystemBlockViewModel systemBlockViewModel;

        public INavigationService Navigation
        { get; set; }

        public SystemBlockComponentsViewModel SystemBlockComponentsViewModel
        {
            get => systemBlockComponentsViewModel;
            set
            {
                systemBlockComponentsViewModel = value;
                OnPropertyChanged(nameof(SystemBlockComponentsViewModel));
            }
        }

        public HomePageViewModel HomePageViewModel
        {
            get => homePageViewModel;
            set
            {
                homePageViewModel = value;
                OnPropertyChanged(nameof(HomePageViewModel));
            }
        }

        public CollectedViewModel CollectedViewModel
        {
            get => collectedViewModel;
            set
            {
                collectedViewModel = value;
                OnPropertyChanged(nameof(CollectedViewModel));
            }
        }

        public SystemBlockViewModel SystemBlockViewModel
        {
            get => systemBlockViewModel;
            set
            {
                systemBlockViewModel = value;
                OnPropertyChanged(nameof(SystemBlockViewModel));
            }
        }

        public MainViewModel(INavigationService navigationService,
                             SystemBlockComponentsViewModel systemBlockComponentsViewModel,
                             HomePageViewModel homePageViewModel,
                             CollectedViewModel collectedViewModel,
                             SystemBlockViewModel systemBlockViewModel)
        {
            Navigation = navigationService;

            SystemBlockComponentsViewModel = systemBlockComponentsViewModel;
            HomePageViewModel = homePageViewModel;
            CollectedViewModel = collectedViewModel;
            SystemBlockViewModel = systemBlockViewModel;
        }

    }
}
