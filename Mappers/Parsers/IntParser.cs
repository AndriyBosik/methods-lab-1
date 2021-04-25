using System;

using Mappers.Abstraction;

namespace Mappers.Parsers
{
    class IntParser: ValueParser<Int32>
    {
        protected override int Parse(String value)
        {
            return Int32.Parse(value);
        }
    }
}
