namespace CompanyHierarchy
{
    public interface IEmployee
    {
        string FirstName { get;}
        string LastName { get;}
        string Department { get;}
        decimal Salary { get;} 
        decimal GetSalary();
    }
}