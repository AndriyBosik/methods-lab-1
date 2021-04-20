using System;
using System.Collections.Generic;
using System.Text;

using Data;

using Models;

namespace Mappers
{
    public class SystemBlockHullMapper: IComponentMapper<Models.SystemBlockHull>
    {
        public Models.SystemBlockHull Map(Component component)
        {
            Models.SystemBlockHull systemBlockHull = new Models.SystemBlockHull
            {
                Type = ComponentType.SystemBlockHull,
                Id = component.Id,
                Title = component.Title,
                Price = component.Price
            };
            if (component.SystemBlockHull != null)
                systemBlockHull.AvailablePowerSupplySize = new Tuple<Int32, Int32, Int32>(
                    component.SystemBlockHull.Width,
                    component.SystemBlockHull.Height,
                    component.SystemBlockHull.Length
                );

            return systemBlockHull;
        }
    }
}
