namespace CompanyHierarchy
{
    public class Junior : IEmployee
    {
        public Junior(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = 900;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Department { get; }
        public decimal Salary { get; }

        public decimal GetSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is Junior engineer.";
        }
    }
}