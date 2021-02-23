using System;

namespace Entities
{
    abstract public class BaseEntity<K, T> where T: BaseEntity<K, T>
    {
        public K Key
        { get; set; }
    }
}
