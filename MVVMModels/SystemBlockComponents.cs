using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Models;

using ApplicationLogic.Services;
using ApplicationLogic.Interfaces;

namespace MVVMModels
{
    public class SystemBlockComponents: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string status;

        public IDictionary<ComponentType, ObservableCollection<SystemComponentBase>> Components
        { get; set; }

        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public SystemBlockComponents(IComputerService service)
        {
            Components = new Dictionary<ComponentType, ObservableCollection<SystemComponentBase>>();

            Components[ComponentType.MemoryCard] = new ObservableCollection<SystemComponentBase>(service.GetMemoryCards().Cast<SystemComponentBase>().ToList());
            Components[ComponentType.Motherboard] = new ObservableCollection<SystemComponentBase>(service.GetMotherboards().Cast<SystemComponentBase>().ToList());
            Components[ComponentType.PowerSupply] = new ObservableCollection<SystemComponentBase>(service.GetPowerSuppliers().Cast<SystemComponentBase>().ToList());
            Components[ComponentType.Processor] = new ObservableCollection<SystemComponentBase>(service.GetProcessors().Cast<SystemComponentBase>().ToList());
            Components[ComponentType.SystemBlockHull] = new ObservableCollection<SystemComponentBase>(service.GetSystemBlockHulls().Cast<SystemComponentBase>().ToList());
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
