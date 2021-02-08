using System;

namespace ComputerSalon.Models
{
    abstract class Base<T> where T: Base<T>
    {
        private static int counter = 1;
        public int id
        { get; private set; }

        public Base()
        {
            id = counter;
            counter++;
        }
    }
}
