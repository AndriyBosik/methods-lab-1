using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace ComputerSalonMVVM.ViewModels
{
    abstract class ViewModelBase: INotifyPropertyChanged
    {
        private object parameter;

        public virtual object Parameter
        {
            get => parameter;
            set
            {
                parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
