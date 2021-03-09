using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class EnergyComponentEntity: BaseEntity<Int32, EnergyComponentEntity>
    {
        Int32 ComponentID
        { get; set; }

        Int32 NeededEnergy
        { get; set; }
    }
}
