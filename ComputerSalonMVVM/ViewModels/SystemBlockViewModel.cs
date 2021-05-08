using ApplicationLogic.Interfaces;
using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.Commands;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ComputerSalonMVVM.ViewModels
{
    class SystemBlockViewModel: ViewModelBase
    {
        private object parameter;
        private ICommand goBackCommand;
        private ICommand saveCommand;
        private ISystemBlockService service;

        public override object Parameter
        {
            get => parameter;
            set
            {
                parameter = value;
                OnPropertyChanged(nameof(Parameter));
                SaveCommand = new SaveSystemBlockCommand(value as SystemBlock, service);
            }
        }

        public ICommand GoBackCommand
        {
            get => goBackCommand;
        }

        public ICommand SaveCommand
        {
            get => saveCommand;
            set
            {
                saveCommand = value;
                OnPropertyChanged(nameof(SaveCommand));
            }
        }

        public SystemBlockViewModel(INavigationService navigation, ISystemBlockService service)
        {
            goBackCommand = new GoBackCommand(navigation);

            this.service = service;
        }

    }
}
