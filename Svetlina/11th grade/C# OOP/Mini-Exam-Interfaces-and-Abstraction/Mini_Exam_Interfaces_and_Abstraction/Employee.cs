namespace Mini_Exam_Interfaces_and_Abstraction;

public class Employee : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public  string Department { get; set; }
    public  int EmployeeId { get; set; }
    
    public Employee(string firstName, string lastName, string department, int employeeId)
    {
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        EmployeeId = employeeId;
    }

    public string StartWorkingDay()
    {
        return $"{FirstName} {LastName} with id {EmployeeId} starts a new working day in the department {Department}.";
    }
}