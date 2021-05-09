﻿using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Models;

using ApplicationLogic.Services;
using ApplicationLogic.Interfaces;
using System.Threading.Tasks;

namespace MVVMModels
{
    public class SystemBlockComponents: INotifyPropertyChanged
    {
        private string status;
        private IComputerService service;

        public event PropertyChangedEventHandler PropertyChanged;


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
            this.service = service;
            Components = new Dictionary<ComponentType, ObservableCollection<SystemComponentBase>>();

            InitDictionary();

            InitComponentsData();
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitDictionary()
        {
            Components[ComponentType.MemoryCard] = new ObservableCollection<SystemComponentBase>();
            Components[ComponentType.Motherboard] = new ObservableCollection<SystemComponentBase>();
            Components[ComponentType.Processor] = new ObservableCollection<SystemComponentBase>();
            Components[ComponentType.PowerSupply] = new ObservableCollection<SystemComponentBase>();
            Components[ComponentType.SystemBlockHull] = new ObservableCollection<SystemComponentBase>();
        }

        private async void InitComponentsData()
        {
            AddElements(ComponentType.MemoryCard, await service.GetMemoryCards());
            AddElements(ComponentType.Motherboard, await service.GetMotherboards());
            AddElements(ComponentType.Processor, await service.GetProcessors());
            AddElements(ComponentType.PowerSupply, await service.GetPowerSuppliers());
            AddElements(ComponentType.SystemBlockHull, await service.GetSystemBlockHulls());
        }

        private void AddElements<T>(ComponentType type, IList<T> components) where T: SystemComponentBase
        {
            foreach (T component in components)
            {
                Components[type].Add((SystemComponentBase)component);
            }
        }

        private ObservableCollection<SystemComponentBase> GetObservable<T>(IList<T> components)
        {
            return new ObservableCollection<SystemComponentBase>(
                components
                    .Cast<SystemComponentBase>()
                    .ToList()
            );
        }
    }
}
