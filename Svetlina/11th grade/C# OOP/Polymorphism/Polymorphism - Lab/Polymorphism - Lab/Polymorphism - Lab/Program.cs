﻿using Polymorphism___Lab;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            Console.WriteLine(mathOperation.Add(2, 3));
            Console.WriteLine(mathOperation.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOperation.Add(2.2m, 3.3m, 4.4m));
        }
    }
}