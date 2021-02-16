using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayer.SystemBlocks;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayerData;

namespace Salon
{
    public class Program
    {
        private IGlobalService globalService;

        public Program(IGlobalService globalService)
        {
            this.globalService = globalService;
        }

        public void Start()
        {
            var dataReader = new ConsoleDataReader(globalService);
            var systemBlock = new SystemBlock();
            var salon = new Salon(dataReader, systemBlock);
            salon.ProcessSystemBlock();

            Console.ReadKey();
        }
    }
}
