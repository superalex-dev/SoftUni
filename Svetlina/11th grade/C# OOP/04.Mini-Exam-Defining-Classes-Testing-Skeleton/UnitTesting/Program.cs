using System;
using UnitTesting;

namespace UnitTesting
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] customerInfo = Console.ReadLine().Split(", ");
            int customerId = int.Parse(customerInfo[0]);
            string name = customerInfo[1];
            int age = int.Parse(customerInfo[2]);
            string email = customerInfo[3];

            Customer customer = new Customer(customerId, name, age, email);

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Bonus")
                {
                    int points = int.Parse(tokens[2]);
                    customer.AddBonusPoints(points);
                }
                else if (tokens[0] == "Exchange")
                {
                    int points = int.Parse(tokens[1]);
                    customer.ExchangePoints(points);
                }
            }
        }
    }
}