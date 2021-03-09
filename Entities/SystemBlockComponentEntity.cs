using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class SystemBlockComponentEntity: BaseEntity<Int32, SystemBlockComponentEntity>
    {
        Int32 ComponentID
        { get; set; }

        Int32 SystemBlockID
        { get; set; }
    }
}
