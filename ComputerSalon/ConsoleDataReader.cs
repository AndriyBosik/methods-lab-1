using ComputerSalon.Models;
using System;

using ComputerSalon.DAO;

namespace ComputerSalon
{
    class ConsoleDataReader : IDataReader
    {
        public MemoryCard GetMemoryCard()
        {
            var dao = new MemoryCardDAO();
            Console.WriteLine("Select Memory Card: ");
            return GetFromConsole<MemoryCard>(dao);
        }

        public Motherboard GetMotherboard()
        {
            var dao = new MotherboardDAO();
            Console.WriteLine("Select Motherboard: ");
            return GetFromConsole<Motherboard>(dao);
        }

        public PowerSupply GetPowerSupply()
        {
            var dao = new PowerSupplyDAO();
            Console.WriteLine("Select Power Supply: ");
            return GetFromConsole<PowerSupply>(dao);
        }

        public Processor GetProcessor()
        {
            var dao = new ProcessorDAO();
            Console.WriteLine("Select Processor: ");
            return GetFromConsole<Processor>(dao);
        }

        public SystemBlockHull GetSystemBlockHull()
        {
            var dao = new SystemBlockHullDAO();
            Console.WriteLine("Select System Block Hull: ");
            return GetFromConsole<SystemBlockHull>(dao);
        }

        private T GetFromConsole<T>(DAO<T> dao) where T: Base<T>
        {
            var items = dao.ReadAll();
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }

    }
}
