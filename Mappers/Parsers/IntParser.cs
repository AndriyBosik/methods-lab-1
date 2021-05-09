using System;

using Mappers.Abstraction;

namespace Mappers.Parsers
{
    class IntParser: ValueParser<Int32>
    {
        protected override int Parse(String value)
        {
            if (value == null)
            {
                return 0;
            }
            return Int32.Parse(value);
        }
    }
}
