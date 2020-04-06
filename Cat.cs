using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Cat
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }

        public Cat()
        {

        }
        public void Mew()
        {
            Console.WriteLine("Mew Mew Mew");
        }
    }
}
