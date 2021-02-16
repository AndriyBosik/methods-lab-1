using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Salon.Interfaces;

using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayerData;

namespace Salon
{
    class Salon
    {
        private IDataReader dataReader;
        private ISystemBlock systemBlock;
        public Salon(IDataReader dataReader, ISystemBlock systemBlock)
        {
            this.dataReader = dataReader;
            this.systemBlock = systemBlock;
        }

        public void ProcessSystemBlock()
        {
            CollectSystemBlock();

            if (systemBlock.IsWorking())
                Console.WriteLine($"System block is working. The price is ${systemBlock.Price}");
            else
                Console.WriteLine("System block can not be collected");
        }

        private void CollectSystemBlock()
        {
            systemBlock.AddComponent(dataReader.GetMotherboard());
            systemBlock.AddComponent(dataReader.GetMemoryCard());
            systemBlock.AddComponent(dataReader.GetProcessor());
            systemBlock.AddComponent(dataReader.GetPowerSupply());
            systemBlock.AddComponent(dataReader.GetSystemBlockHull());
        }
    }
}
