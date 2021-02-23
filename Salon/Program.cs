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
        public static void Main(string[] args)
        {
            var dataReader = new ConsoleDataReader();
            var salon = new Salon(dataReader);
            salon.ProcessSystemBlock();

            Console.ReadKey();
        }
    }
}
