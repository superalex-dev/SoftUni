using System;

namespace CompanyHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                var firstName = input[0];
                var lastName = input[1];
                var department = input[2];

                switch (department)
                {
                    case "Sales":
                        var profits = decimal.Parse(input[3]);
                        employees.Add(new SalesEmployee(firstName, lastName, department, profits));
                        break;

                    case "Engineering":
                        var yearsService = int.Parse(input[3]);
                        employees.Add(new Engineer(firstName, lastName, department, yearsService));
                        break;

                    case "Junior":
                        employees.Add(new Junior(firstName, lastName, department));
                        break;

                    default:
                        throw new ArgumentException("Invalid department");
                }
            }

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Receives a salary of {employee.GetSalary()}.");
            }
        }
    }
}