namespace Mini_Exam_Interfaces_and_Abstraction;

public class Customer : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}