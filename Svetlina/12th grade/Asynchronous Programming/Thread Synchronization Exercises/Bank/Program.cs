using System;
using System.Threading;

class Account
{
    private int balance;
    private readonly object balanceLock = new object();

    public Account(int initialBalance)
    {
        balance = initialBalance;
    }

    public int Withdraw(int amount)
    {
        lock (balanceLock)
        {
            if (balance < 0)
            {
                throw new Exception("Negative Balance");
            }

            if (balance >= amount)
            {
                Console.WriteLine($"Balance before Withdrawal: {balance}");
                Console.WriteLine($"Amount to Withdraw: -{amount}");
                balance -= amount;
                Console.WriteLine($"Balance after Withdrawal: {balance}");
                return amount;
            }

            return 0;
        }
    }
}

class Program
{
    static void Main()
    {
        Account account = new Account(500);
        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() => {
                try
                {
                    account.Withdraw(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
        }

        foreach (var thread in threads)
        {
            thread.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }
    }
}