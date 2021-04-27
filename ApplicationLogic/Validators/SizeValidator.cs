using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApplicationLogic.Interfaces;
using Models;

namespace ApplicationLogic.Validators
{
    public class SizeValidator : IValidator
    {
        public IValidator Next { get; set; }

        public bool Validate(ISystemBlockHandler systemBlock)
        {
            var systemBlockHull = (SystemBlockHull) systemBlock.GetContainer(ComponentType.SystemBlockHull).GetItems().FirstOrDefault();
            var powerSupply = (PowerSupply) systemBlock.GetContainer(ComponentType.PowerSupply).GetItems().FirstOrDefault();

            if (!systemBlockHull.CanAccommodatePowerSupply(powerSupply))
                return false;

            return Next == null ? true : Next.Validate(systemBlock);
        }
    }
}
