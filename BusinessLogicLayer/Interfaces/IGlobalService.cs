using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayerData;

namespace BusinessLogicLayer.Interfaces
{
    public interface IGlobalService
    {
        IService<MemoryCard> MemoryCardService
        { get; }

        IService<Motherboard> MotherboardService
        { get; }

        IService<PowerSupply> PowerSupplyService
        { get; }

        IService<Processor> ProcessorService
        { get; }

        IService<SystemBlockHull> SystemBlockHullService
        { get; }
    }
}
