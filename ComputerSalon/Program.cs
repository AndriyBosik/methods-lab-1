using System;
using ComputerSalon.Models;

namespace ComputerSalon
{
    class Program
    {
        private IDataReader dataReader;
        private SystemBlock systemBlock;
        public Program(IDataReader dataReader)
        {
            this.dataReader = dataReader;
        }
        static void Main(string[] args)
        {
            var program = new Program(new ConsoleDataReader());
            program.TryCollectSet();
        }

        public void TryCollectSet()
        {
            var memoryCard = dataReader.GetMemoryCard();
            var motherboard = dataReader.GetMotherboard();
            var powerSupply = dataReader.GetPowerSupply();
            var processor = dataReader.GetProcessor();
            var systemBlockHull = dataReader.GetSystemBlockHull();

            systemBlock = new SystemBlock(systemBlockHull, powerSupply, memoryCard, motherboard, processor);
            if (!systemBlock.IsWorking())
                Console.WriteLine("System Block can not be collected");
            else
                Console.WriteLine($"System Block collected. Price: {systemBlock.GetPrice()}");
        }
    }
}
