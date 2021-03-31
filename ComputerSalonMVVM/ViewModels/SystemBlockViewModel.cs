using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Models;
using ApplicationLogic;
using System;
using System.Windows;
using System.Windows.Controls;

using MVVMModels;

namespace ComputerSalonMVVM.ViewModels
{
    public class SystemBlockViewModel: INotifyPropertyChanged
    {
        private SystemBlock systemBlock;
        private ObservableCollection<SystemComponentBase> selected;

        public event PropertyChangedEventHandler PropertyChanged;

        public MVVMModels.ComponentsHolder Holder
        { get; set; } = new MVVMModels.ComponentsHolder();

        public SystemBlock SystemBlock
        {
            get { return systemBlock; }
            set {
                systemBlock = value;
                OnPropertyChanged("SystemBlock");
            }
        }

        public ObservableCollection<SystemComponentBase> Selected
        {
            get { return selected; }
            set
            {
                selected = value;
            }
        }

        public SystemBlockViewModel()
        {
            SystemBlock = new SystemBlock();

            Selected = new ObservableCollection<SystemComponentBase>();
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
