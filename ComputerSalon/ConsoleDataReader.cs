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
            var items = dao.ReadAll();
            Console.WriteLine("Select Memory Card: ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }

        public Motherboard GetMotherboard()
        {
            var dao = new MotherboardDAO();
            var items = dao.ReadAll();
            Console.WriteLine("Select Motherboard: ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }

        public PowerSupply GetPowerSupply()
        {
            var dao = new PowerSupplyDAO();
            var items = dao.ReadAll();
            Console.WriteLine("Select Power Supply: ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }

        public Processor GetProcessor()
        {
            var dao = new ProcessorDAO();
            var items = dao.ReadAll();
            Console.WriteLine("Select Processor: ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }

        public SystemBlockHull GetSystemBlockHull()
        {
            var dao = new SystemBlockHullDAO();
            var items = dao.ReadAll();
            Console.WriteLine("Select System Block Hull: ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {items[i]}");
            }
            var number = Convert.ToInt32(Console.ReadLine());
            return items[number - 1];
        }

    }
}
