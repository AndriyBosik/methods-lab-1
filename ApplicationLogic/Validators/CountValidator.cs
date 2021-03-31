using System;
using System.Collections.Generic;
using System.Text;

using ApplicationLogic.Interfaces;
using Models;

namespace ApplicationLogic.Validators
{
    class CountValidator : IValidator
    {
        public IValidator Next
        { get; set; }

        public bool Validate(ISystemBlockHandler systemBlock)
        {
            foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
            {
                if (systemBlock.GetComponents(componentType).Count < 1)
                    return false;
            }
            return Next == null ? true : Next.Validate(systemBlock);
        }
    }
}
