namespace Mini_Exam_Interfaces_and_Abstraction;

public class Guest : Customer
{
    public Guest(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    
    public string NewGuest()
    {
        return $"Mr/Ms/Mrs {FirstName} {LastName} registers as a guest.";
    }
}