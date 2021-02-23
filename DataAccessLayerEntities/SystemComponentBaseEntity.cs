using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerEntities
{
    abstract public class SystemComponentBaseEntity<K, T>: BaseEntity<K, T> where T: SystemComponentBaseEntity<K, T>
    {
        public string Title
        { get; set; }

        public int Price
        { get; set; }
    }
}
