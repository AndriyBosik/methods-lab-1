using System;
using System.ComponentModel;

using Models.Interfaces;

namespace Models
{
    abstract public class SystemComponentBase: INotifyPropertyChanged
    {
        private bool isSelected;

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        public Int32 Id
        { get; set; }

        public string Title
        { get; set; }

        public Double Price
        { get; set; }

        public ComponentType Type
        { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract string ShowInformation();

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
