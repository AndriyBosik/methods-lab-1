using System;

using ComputerSalonCLI.Interfaces;

using ApplicationLogic.Handlers;
using ApplicationLogic.Interfaces;

namespace ComputerSalonCLI
{
    class Salon
    {
        private IDataReader dataReader;
        public Salon(IDataReader dataReader)
        {
            this.dataReader = dataReader;
        }

        public void ProcessSystemBlock()
        {
            ISystemBlockHandler handler = CollectSystemBlock();

            if (handler.IsWorking())
                Console.WriteLine($"System block is working. The price is ${handler.Price}");
            else
                Console.WriteLine("System block can not be collected");
        }

        private ISystemBlockHandler CollectSystemBlock()
        {
            ISystemBlockHandler systemBlock = new SystemBlockHandler();

            systemBlock.AddComponent(dataReader.GetMotherboard());
            systemBlock.AddComponent(dataReader.GetMemoryCard());
            systemBlock.AddComponent(dataReader.GetProcessor());
            systemBlock.AddComponent(dataReader.GetPowerSupply());
            systemBlock.AddComponent(dataReader.GetSystemBlockHull());

            return systemBlock;
        }
    }
}
