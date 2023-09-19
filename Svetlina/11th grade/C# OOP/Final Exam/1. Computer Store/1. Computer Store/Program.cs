using Computer_Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Store
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ILaptop> laptops = new List<ILaptop>();
            List<string> commands = new List<string>();

            string input = Console.ReadLine();
            while (input != "Buy")
            {
                commands.Add(input);
                input = Console.ReadLine();
            }
            try
            {
                foreach (string inputString in commands)
                {
                    string[] commandString = inputString.Split(" ");
                    string command = commandString[0];

                    switch (command)
                    {
                        case "AddLaptop":
                            string laptopType = commandString[1];
                            int id = int.Parse(commandString[2]);
                            string model = commandString[3];
                            decimal price = decimal.Parse(commandString[4]);

                            switch (laptopType)
                            {
                                case "TraditionalLaptop":
                                    laptops.Add(new TraditionalLaptop(id, model, price));
                                    break;
                                case "HybridLaptop":
                                    laptops.Add(new HybridLaptop(id, model, price));
                                    break;
                                default:
                                    throw new ArgumentException("Invalid laptop type.");
                            }
                            break;

                        case "AddHardware":
                            int laptopId = int.Parse(commandString[1]);
                            int hardwarePartId = int.Parse(commandString[2]);
                            string hardwareModel = commandString[3];
                            decimal hardwarePrice = decimal.Parse(commandString[4]);
                            int overallPerformance = int.Parse(commandString[5]);
                            int generation = int.Parse(commandString[6]);

                            ILaptop laptop = laptops.SingleOrDefault(x => x.Id == laptopId);
                            if (laptop == null)
                            {
                                throw new ArgumentException("Laptop not found.");
                            }

                            IHardware hardware = new Hardware(hardwarePartId, hardwareModel, hardwarePrice, overallPerformance, generation);
                            laptop.AddHardware(hardware);
                            break;

                        default:
                            throw new ArgumentException("Invalid command.");
                    }
                }

                StringBuilder stringBuilder = new StringBuilder();

                foreach (ILaptop laptop in laptops)
                {
                    stringBuilder.AppendLine(laptop.ToString());
                }

                Console.WriteLine(stringBuilder.ToString().Trim());

            }
            catch (ArgumentException ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
