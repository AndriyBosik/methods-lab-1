using System;
using System.Collections.Generic;
using System.Text;

using ApplicationLogic.Interfaces;
using Models;

namespace ApplicationLogic.Validators
{
    public class ContainerValidator : IValidator
    {
        public IValidator Next
        { get; set; }

        public bool Validate(ISystemBlockHandler systemBlock)
        {
            foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
            {
                if (!systemBlock.GetContainer(componentType).IsValid())
                    return false;
            }
            return Next == null ? true : Next.Validate(systemBlock);
        }
    }
}
