using System;

namespace Defining_Classes_Advanced_Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee dan = new Employee("Dan", 20);
            Employee joey = new Employee("Joey", 18);
            Employee tommy = new Employee("Tommy", 43);
            
            Console.WriteLine("Name: " + dan.Name + ", Age: " + dan.Age);
            Console.WriteLine("Name: " + joey.Name + ", Age: " + joey.Age);
            Console.WriteLine("Name: " + tommy.Name + ", Age: " + tommy.Age);
        }
    }
}
