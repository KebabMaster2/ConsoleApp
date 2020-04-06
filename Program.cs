using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cat> cats = new List<Cat>();
            Random rand = new Random();

            for(int i = 0; i < 100; i++)
            {
                cats.Add(new Cat());
                cats[i].Name = "Name" + i;
                cats[i].Age = rand.Next(1, 20);
                cats[i].Weight = (double)rand.Next(1,200) / (double)10;
            }

            foreach(Cat cat in cats)
            {
                Console.WriteLine(cat.Name + ", "+cat.Age + ", " + cat.Weight+" kg");
            }

            cats[0].Mew();
            Dog dog = new Dog();
            dog.SayVau();


            Console.ReadKey();
        }
    }
    
}
