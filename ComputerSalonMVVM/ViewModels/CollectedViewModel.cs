using ApplicationLogic.Interfaces;
using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.Commands;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ComputerSalonMVVM.ViewModels
{
    class CollectedViewModel: ViewModelBase
    {
        private ISystemBlockService systemBlockService;
        private ICommand goBackCommand;
        private SystemBlock selectedSystemBlock;
        private ObservableCollection<SystemBlock> systemBlocks;

        public ICommand GoBackCommand
        {
            get => goBackCommand;
        }

        public SystemBlock SelectedSystemBlock
        {
            get => selectedSystemBlock;
            set
            {
                selectedSystemBlock = value;
                OnPropertyChanged(nameof(SelectedSystemBlock));
            }
        }

        public ObservableCollection<SystemBlock> SystemBlocks
        {
            get => systemBlocks;
            set
            {
                systemBlocks = value;
                OnPropertyChanged(nameof(SystemBlocks));
            }
        }

        public CollectedViewModel(INavigationService navigation, ISystemBlockService systemBlockService)
        {
            this.systemBlockService = systemBlockService;

            goBackCommand = new GoBackCommand(navigation);

            SelectedSystemBlock = new SystemBlock();
            GetSystemBlocks();
        }

        private async void GetSystemBlocks()
        {
            IList<SystemBlock> allSystemBlocks = await systemBlockService.GetSystemBlocksAsync();
            SystemBlocks = new ObservableCollection<SystemBlock>(allSystemBlocks);
        }
    }
}
