using System;
using System.Collections.Generic;
using System.Linq;

using Data;

namespace Mappers.Abstraction
{
    abstract class ValueParser<T>
    {
        public T Parse(ICollection<Value> values, String attributeTitle)
        {
            return Parse(values.Where(value => value.Attribute.Title == attributeTitle).Select(value => value.Data).FirstOrDefault());
        }

        protected abstract T Parse(String value);
    }
}
