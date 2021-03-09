using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class TypeEntity: BaseEntity<Int32, TypeEntity>
    {
        String Type
        { get; set; }
    }
}
