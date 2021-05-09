using System.ComponentModel;
using System.Windows.Input;

using MVVMModels;

using Models;

using ComputerSalonMVVM.Commands;
using ApplicationLogic.Interfaces;
using ComputerSalonMVVM.Abstraction;
using System.Windows;

namespace ComputerSalonMVVM.ViewModels
{
    class SystemBlockComponentsViewModel: ViewModelBase
    {
        private ICommand checkCommand;
        private ICommand goBackCommand;
        private SystemBlock systemBlock;

        public ICommand CheckCommand
        {
            get => checkCommand;
        }

        public ICommand GoBackCommand
        {
            get => goBackCommand;
        }

        public SystemBlockComponents Components
        { get; set; }

        public SystemBlock SystemBlock
        {
            get => systemBlock;
            set
            {
                systemBlock = value;
                OnPropertyChanged(nameof(SystemBlock));
            }
        }

        public SystemBlockComponentsViewModel(INavigationService navigation, SystemBlockComponents components, ISystemBlockHandler handler)
        {
            Components = components;

            systemBlock = new SystemBlock();

            checkCommand = new CheckSystemBlockCommand(systemBlock, Components, handler, navigation);
            goBackCommand = new GoBackCommand(navigation);
        }
    }
}
