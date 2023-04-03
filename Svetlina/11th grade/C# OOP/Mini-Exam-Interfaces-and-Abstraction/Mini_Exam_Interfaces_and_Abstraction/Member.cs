namespace Mini_Exam_Interfaces_and_Abstraction;

public class Member : Customer
{
    public int MembershipId { get; set; }

    public Member(string firstName, string lastName, int membershipId) : base(firstName, lastName)
    {
        MembershipId = membershipId;
    }
    
    public string GetMemberCard(string freeAccess)
    {
        return $"Member {FirstName} {LastName} with membership number {MembershipId} gets free access to the {freeAccess}.";
    }
}