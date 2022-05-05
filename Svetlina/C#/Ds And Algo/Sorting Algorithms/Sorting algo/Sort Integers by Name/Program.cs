using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort_Integers_by_Name
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dick = new Dictionary<string, string>()
            {
                {"0", "zero" },
                {"1", "one" },
                {"2", "two" },
                {"3", "three" },
                {"4", "four" },
                {"5", "five" },
                {"6", "six" },
                {"7", "seven" },
                {"8", "eight" },
                {"9", "nine" },
            };
            int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            string[] res = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string curr = arr[i].ToString();
                string currNumsAsT = "";
                foreach (var item in curr)
                {
                    currNumsAsT += dick[item.ToString()] + "-";
                }

                currNumsAsT.Remove(currNumsAsT.Length - 1);
                res[i] = currNumsAsT;
            }
            res = res.OrderBy(x => x).ToArray();

            for (int i = 0; i < res.Length; i++)
            {
                string[] curr = res[i].Split('-');
                string num = "";
                foreach (var item in curr)
                {
                    foreach (var val in dick)
                    {
                        if (val.Value == item)
                        {
                            num += val.Key;
                        }
                    }
                }
                res[i] = num;
            }
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
