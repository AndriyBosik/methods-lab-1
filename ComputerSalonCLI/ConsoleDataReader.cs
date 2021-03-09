using System;

using ComputerSalonCLI.Interfaces;

using ApplicationLogic.Services;
using ApplicationLogic.Interfaces;
using Models;

namespace ComputerSalonCLI
{
    class ConsoleDataReader: IDataReader
    {
        public ConsoleDataReader() {}

        public MemoryCard GetMemoryCard()
        {
            Console.WriteLine("Select Memory Card: ");
            //return GetFromConsole(new MemoryCardService());
            return null;
        }

        public Motherboard GetMotherboard()
        {
            Console.WriteLine("Select Motherboard: ");
            //return GetFromConsole(new MotherboardService());
            return null;
        }

        public PowerSupply GetPowerSupply()
        {
            Console.WriteLine("Select Power Supply: ");
            //return GetFromConsole(new PowerSupplyService());
            return null;
        }

        public Processor GetProcessor()
        {
            Console.WriteLine("Select Processor: ");
            //return GetFromConsole(new ProcessorService());
            return null;
        }

        public SystemBlockHull GetSystemBlockHull()
        {
            Console.WriteLine("Select System Block Hull: ");
            //return GetFromConsole(new SystemBlockHullService());
            return null;
        }

        /*private T GetFromConsole<T>(IService<T> service) where T : SystemComponentBase
        {
            var items = service.GetAll();
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i].ShowInformation()}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }*/
    }
}
