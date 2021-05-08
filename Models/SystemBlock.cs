using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SystemBlock: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string title;

        public Double Price
        {
            get => Components.Sum(component => component.Price);
        }

        public String Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public IList<SystemComponentBase> Components
        { get; set; }

        public SystemBlock()
        {
            Components = new List<SystemComponentBase>();
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
