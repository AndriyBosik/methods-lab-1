using System;

namespace ComputerSalon.Models
{
    abstract class Base<T> where T : Base<T>
    {
        private static int counter = 1;

        public String Title;
        public Int32 Price;
        public int id
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
