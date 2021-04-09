using System;
using System.Windows;
using System.Windows.Input;

namespace ComputerSalonMVVM.Commands
{
    class SaveSystemBlockCommand: ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Some message", "Some title");
        }
    }
}
