using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Dog
    {
        public string Name { get; set;  }
        public int Age { get; set; }
        public Dog()
        {
            
        }
        public void SayVau()
        {
            Console.WriteLine("Vau vau vau");
        }
    }
}
