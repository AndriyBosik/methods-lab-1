using System;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;

using ApplicationLogic.Handlers;

using Models;
using System.Collections.Specialized;

namespace MVVMModels
{
    public class SystemBlock: INotifyPropertyChanged
    {
        private string text = "";

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ObservableCollection<SystemComponentBase> Components
        { get; set; }

        public String Status
        {
            set
            {
                text = value;
                OnPropertyChanged("Status");
            }
            get
            {
                return text;
            }
        }

        public SystemBlock()
        {
            Components = new ObservableCollection<SystemComponentBase>();
            Components.CollectionChanged += UpdateStatus;
        }

        private void UpdateStatus(object sender, NotifyCollectionChangedEventArgs args)
        {
            this.Status = CheckSystemBlock();
        }

        private String CheckSystemBlock()
        {
            SystemBlockHandler handler = new SystemBlockHandler();

            foreach (var component in Components)
            {
                handler.AddComponent(component);
            }

            if (handler.IsWorking())
            {
                return "SystemBlock can be collected. The price is: " + handler.Price;
            }
            return "SystemBlock can not be collected.";
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
