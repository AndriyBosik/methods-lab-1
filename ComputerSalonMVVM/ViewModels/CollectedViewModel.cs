using ApplicationLogic.Interfaces;
using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.Commands;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ComputerSalonMVVM.ViewModels
{
    class CollectedViewModel: ViewModelBase
    {
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
            goBackCommand = new GoBackCommand(navigation);

            SelectedSystemBlock = new SystemBlock();
            SystemBlocks = new ObservableCollection<SystemBlock>(systemBlockService.GetSystemBlocks());
        }
    }
}
