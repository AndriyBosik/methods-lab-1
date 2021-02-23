using System;

using Salon.Interfaces;

using BusinessLogic.Services;
using BusinessLogic.Interfaces;
using Models;

namespace Salon
{
    class ConsoleDataReader: IDataReader
    {
        public ConsoleDataReader() {}

        public MemoryCard GetMemoryCard()
        {
            Console.WriteLine("Select Memory Card: ");
            return GetFromConsole(new MemoryCardService());
        }

        public Motherboard GetMotherboard()
        {
            Console.WriteLine("Select Motherboard: ");
            return GetFromConsole(new MotherboardService());
        }

        public PowerSupply GetPowerSupply()
        {
            Console.WriteLine("Select Power Supply: ");
            return GetFromConsole(new PowerSupplyService());
        }

        public Processor GetProcessor()
        {
            Console.WriteLine("Select Processor: ");
            return GetFromConsole(new ProcessorService());
        }

        public SystemBlockHull GetSystemBlockHull()
        {
            Console.WriteLine("Select System Block Hull: ");
            return GetFromConsole(new SystemBlockHullService());
        }

        private T GetFromConsole<T>(IService<T> service) where T : SystemComponentBase
        {
            var items = service.GetAll();
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i].ShowInformation()}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }
    }
}
