using System.ComponentModel;
using System.Windows.Input;

using MVVMModels;

using Models;

using ComputerSalonMVVM.Commands;
using System.Windows;

namespace ComputerSalonMVVM.ViewModels
{
    public class SystemBlockViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand checkCommand;
        private ICommand saveCommand;
        private ICommand exitCommand;
        private SystemBlock systemBlock;

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

        public SystemBlockViewModel()
        {
            Components = new SystemBlockComponents();

            systemBlock = new SystemBlock();

            checkCommand = new CheckSystemBlockCommand(systemBlock, Components);
            saveCommand = new SaveSystemBlockCommand(systemBlock);
            exitCommand = new ExitCommand();
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
