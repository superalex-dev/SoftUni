using System;

namespace FinalExam
{
    public class SpecVariations
    {
        static char[] arr;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            arr = new char[n];

            SpecialVariations(n, 0);
        }

        private static void SpecialVariations(int n, int current)
        {
            if (current >= n)
            {
                Console.WriteLine(String.Join("", arr));
                return;
            }

            for (int i = 97; i < 97 + n; i++)
            {
                arr[current] = (char)i;
                if (current >= 1)
                {
                    if (arr[current] >= arr[current - 1])
                    {
                        SpecialVariations(n, current + 1);
                    }
                }
                else
                {
                    SpecialVariations(n, current + 1);
                }
            }
        }
    }
}