using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayer.Interfaces;
using BusinessLogicLayerData;

namespace BusinessLogicLayer.Validators
{
    public class SizeValidator : IValidator
    {
        public IValidator Next { get; set; }

        public bool Validate(ISystemBlock systemBlock)
        {
            var systemBlockHull = (SystemBlockHull) systemBlock.GetComponents(SystemComponentType.SystemBlockHull).FirstOrDefault();
            var powerSupply = (PowerSupply) systemBlock.GetComponents(SystemComponentType.PowerSupply).FirstOrDefault();

            if (!systemBlockHull.CanAccommodatePowerSupply(powerSupply))
                return false;

            return Next == null ? true : Next.Validate(systemBlock);
        }
    }
}
