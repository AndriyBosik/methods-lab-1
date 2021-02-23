using System;

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
