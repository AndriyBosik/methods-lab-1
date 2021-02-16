﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;

namespace BusinessLogicLayer.Interfaces
{
    public interface IContainer
    {
        Int32 MaxCount
        { get; set; }

        void AddComponent(SystemComponentBase systemComponent);

        bool CanAddOneMoreComponent();

        IList<SystemComponentBase> GetItems();

        void Print();
    }
}
