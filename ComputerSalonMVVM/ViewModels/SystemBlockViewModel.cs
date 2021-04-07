using System.ComponentModel;
using System.Windows.Input;

using MVVMModels;

using ComputerSalonMVVM.Commands;

namespace ComputerSalonMVVM.ViewModels
{
    public class SystemBlockViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand checkCommand;
        private ICommand exitCommand;

        public ICommand CheckCommand
        {
            get => checkCommand;
        }

        public ICommand ExitCommand
        {
            get => exitCommand;
        }

        public SystemBlockComponents Components
        { get; set; }

        public SystemBlockViewModel()
        {
            Components = new SystemBlockComponents();

            checkCommand = new CheckSystemBlockCommand(Components);
            exitCommand = new ExitCommand();
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
