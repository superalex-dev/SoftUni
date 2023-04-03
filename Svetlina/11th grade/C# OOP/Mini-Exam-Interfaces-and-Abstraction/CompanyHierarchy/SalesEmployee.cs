namespace CompanyHierarchy
{
    public class SalesEmployee : IEmployee
    {
        public SalesEmployee(string firstName, string lastName, string department, decimal profits)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Profits = profits;
            Salary = 1000;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Department { get; }
        public decimal Salary { get; }
        public decimal Profits { get; }

        public decimal GetSalary()
        {
            return Salary + (Profits * 0.1m);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {Department} has {Profits} profits.";
        }
    }

}