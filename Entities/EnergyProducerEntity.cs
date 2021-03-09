using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class EnergyProducerEntity: BaseEntity<Int32, EnergyProducerEntity>
    {
        Int32 ComponentID
        { get; set; }

        Int32 Width
        { get; set; }

        Int32 Height
        { get; set; }

        Int32 Length
        { get; set; }

        Int32 Energy
        { get; set; }
    }
}
