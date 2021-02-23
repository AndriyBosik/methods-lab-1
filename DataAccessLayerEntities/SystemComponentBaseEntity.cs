using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerEntities
{
    abstract public class SystemComponentBaseEntity<T>: BaseEntity<T> where T: SystemComponentBaseEntity<T>
    {
        public string Title
        { get; set; }

        public int Price
        { get; set; }
    }
}
