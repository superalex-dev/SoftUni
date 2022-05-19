using System;

namespace Final_Exam_Preparation
{
    public class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            long num3 = long.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
                if (num1 > num3)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3);
                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
            }
        }
    }
}
