namespace CompanyHierarchy
{
    public class Engineer : IEmployee
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string department;
        private readonly decimal salary;
        private readonly int yearsService;

        public Engineer(string firstName, string lastName, string department, int yearsService)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.salary = 1300;
            this.yearsService = yearsService;
        }

        public string FirstName => firstName;
        public string LastName => lastName;
        public string Department => department;
        public decimal Salary => salary;
        public int YearsService => yearsService;
        public decimal GetSalary()
        {
            return Salary + (YearsService * 90);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {Department} has {YearsService} years of service.";
        }
    }
}