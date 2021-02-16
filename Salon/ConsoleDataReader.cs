using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Salon.Interfaces;

using BusinessLogicLayer.Services;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayerData;

namespace Salon
{
    class ConsoleDataReader: IDataReader
    {
        private IGlobalService globalService;

        public ConsoleDataReader(IGlobalService globalService)
        {
            this.globalService = globalService;
        }

        public MemoryCard GetMemoryCard()
        {
            Console.WriteLine("Select Memory Card: ");
            return GetFromConsole(globalService.MemoryCardService);
        }

        public Motherboard GetMotherboard()
        {
            Console.WriteLine("Select Motherboard: ");
            return GetFromConsole(globalService.MotherboardService);
        }

        public PowerSupply GetPowerSupply()
        {
            Console.WriteLine("Select Power Supply: ");
            return GetFromConsole(globalService.PowerSupplyService);
        }

        public Processor GetProcessor()
        {
            Console.WriteLine("Select Processor: ");
            return GetFromConsole(globalService.ProcessorService);
        }

        public SystemBlockHull GetSystemBlockHull()
        {
            Console.WriteLine("Select System Block Hull: ");
            return GetFromConsole(globalService.SystemBlockHullService);
        }

        private T GetFromConsole<T>(IService<T> service) where T : SystemComponentBase
        {
            var items = service.GetAll();
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }
    }
}
