using System;

namespace DataAccessLayerEntities
{
    abstract public class BaseEntity<T> where T: BaseEntity<T>
    {
        private static Int32 counter = 1;
        public Int32 Id
        { get; set; }

        public BaseEntity()
        {
            Id = counter;
            counter++;
        }
    }
}
