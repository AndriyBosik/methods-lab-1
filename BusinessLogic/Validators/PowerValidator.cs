using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogic.Interfaces;
using Models;

namespace BusinessLogic.Validators
{
    public class PowerValidator : IValidator
    {
        public IValidator Next { get; set; }

        public bool Validate(ISystemBlock systemBlock)
        {
            var powerSupply = (PowerSupply)systemBlock.GetComponents(SystemComponentType.PowerSupply).FirstOrDefault();

            var consumers = systemBlock.GetPowerConsumers();

            if (!powerSupply.HasEnoughPower(consumers))
                return false;

            return Next == null ? true : Next.Validate(systemBlock);
        }
    }
}
