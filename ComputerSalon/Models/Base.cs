using System;

namespace ComputerSalon.Models
{
    abstract class Base<T> where T : Base<T>
    {
        private static Int32 counter = 1;

        public String Title;
        public Int32 Price;
        public Int32 id
        { get; private set; }

        public Base(String title, Int32 price)
        {
            id = counter;
            counter++;
            this.Title = title;
            this.Price = price;
        }
    }
}
