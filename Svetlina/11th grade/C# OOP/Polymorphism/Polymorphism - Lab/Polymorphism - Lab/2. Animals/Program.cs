using _2._Animals;
using System;

namespace Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Pesho", "Whiskas");
            Dog dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}