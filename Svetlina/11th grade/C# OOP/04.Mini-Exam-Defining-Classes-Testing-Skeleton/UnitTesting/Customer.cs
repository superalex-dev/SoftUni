using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class Customer
    {
        private int customerId;
        private string name;
        private int age;
        private string email;
        private int bonusPoints;

        public Customer(int customerId, string name, int age, string email)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.email = email;
            this.bonusPoints = 10;
        }

        public void AddBonusPoints(int points)
        {
            this.bonusPoints += points;
            Console.WriteLine($"You have {this.bonusPoints} bonus points.");
        }

        public void ExchangePoints(int points)
        {
            if (this.bonusPoints < points)
            {
                Console.WriteLine("You do not have enough bonus points.");
            }
            else
            {
                this.bonusPoints -= points;
                Console.WriteLine($"You have {this.bonusPoints} points left.");
            }
        }
    }
}
