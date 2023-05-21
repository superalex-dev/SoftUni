using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int smallestNumber = FindSmallestNumber(numbers, Math.Min);

            Console.WriteLine(smallestNumber);
        }

        static T FindSmallestNumber<T>(IEnumerable<T> numbers, Func<T, T, T> minFunc)
        {
            T smallestNumber = numbers.First();

            foreach (var number in numbers)
            {
                smallestNumber = minFunc(smallestNumber, number);
            }

            return smallestNumber;
        }
    }
}