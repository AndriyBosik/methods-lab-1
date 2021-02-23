using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Salon.Interfaces;

using BusinessLogicLayer.SystemBlocks;
using BusinessLogicLayer.Interfaces;

namespace Salon
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
            ISystemBlock systemBlock = CollectSystemBlock();

            if (systemBlock.IsWorking())
                Console.WriteLine($"System block is working. The price is ${systemBlock.Price}");
            else
                Console.WriteLine("System block can not be collected");
        }

        private ISystemBlock CollectSystemBlock()
        {
            ISystemBlock systemBlock = new SystemBlock();

            systemBlock.AddComponent(dataReader.GetMotherboard());
            systemBlock.AddComponent(dataReader.GetMemoryCard());
            systemBlock.AddComponent(dataReader.GetProcessor());
            systemBlock.AddComponent(dataReader.GetPowerSupply());
            systemBlock.AddComponent(dataReader.GetSystemBlockHull());

            return systemBlock;
        }
    }
}
