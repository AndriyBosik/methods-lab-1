using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interfaces;

namespace Models
{
    abstract public class SystemComponentBase
    {
        public Int32 Id
        { get; set; }

        public string Title
        { get; set; }

        public Double Price
        { get; set; }

        public ComponentType Type
        { get; set; }

        public abstract string ShowInformation();
    }
}
