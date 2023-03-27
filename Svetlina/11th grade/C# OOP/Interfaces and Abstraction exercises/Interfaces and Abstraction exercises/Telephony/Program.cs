using System;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();
            
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (string number in numbers)
            {
                if (number.Length == 7 || number.Length == 10)
                {
                    if (number.Length == 7)
                    {
                        stationaryPhone.Call(number);

                    }
                    else
                    {
                        smartphone.Call(number);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (string url in urls)
            {
                smartphone.Browse(url);
            }
        }
    }
}