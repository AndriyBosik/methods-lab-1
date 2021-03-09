using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ComponentEntity: BaseEntity<Int32, ComponentEntity>
    {
        Int32 Type
        { get; set; }

        String Title
        { get; set; }

        Int32 Price
        { get; set; }

        Boolean IsMultiply
        { get; set; }
    }
}
