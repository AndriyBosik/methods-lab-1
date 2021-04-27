using System.ComponentModel;
using System.Windows.Input;

using MVVMModels;

using Models;

using ComputerSalonMVVM.Commands;
using ApplicationLogic.Interfaces;

namespace ComputerSalonMVVM.ViewModels
{
    public class SystemBlockViewModel: INotifyPropertyChanged
    {
        private ICommand checkCommand;
        private ICommand saveCommand;
        private ICommand exitCommand;
        private SystemBlock systemBlock;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CheckCommand
        {
            get => checkCommand;
        }

        public ICommand SaveCommand
        {
            get => saveCommand;
        }

        public ICommand ExitCommand
        {
            get => exitCommand;
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

        public SystemBlockViewModel(SystemBlockComponents components, ISystemBlockHandler handler, ISystemBlockService service)
        {
            Components = components;

            systemBlock = new SystemBlock();

            checkCommand = new CheckSystemBlockCommand(systemBlock, Components, handler);
            saveCommand = new SaveSystemBlockCommand(systemBlock, service);
            exitCommand = new ExitCommand();
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
