using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApplicationLogic.Interfaces;
using Models;

namespace ApplicationLogic.Validators
{
    public class PowerValidator : IValidator
    {
        public IValidator Next { get; set; }

        public bool Validate(ISystemBlockHandler systemBlock)
        {
            var powerSupply = (PowerSupply)systemBlock.GetContainer(ComponentType.PowerSupply).GetItems().FirstOrDefault();

            var consumers = systemBlock.GetPowerConsumers();

            if (!powerSupply.HasEnoughPower(consumers))
                return false;

            return Next == null ? true : Next.Validate(systemBlock);
        }
    }
}
