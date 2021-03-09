using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class SystemBlockEntity: BaseEntity<Int32, SystemBlockEntity>
    {
        Int32 ComponentID
        { get; set; }

        Int32 Width
        { get; set; }

        Int32 Height
        { get; set; }

        Int32 Length
        { get; set; }
    }
}
