using System;

namespace Mini_Exam_Interfaces_and_Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            int memberCount = 0;

            while (true)
            {
                string input = Console.ReadLine();
                
                if(input == "End")
                { 
                    break;
                }

                string[] data = input.Split(' ');
                if (data.Length == 2)
                {
                    Guest guest = new Guest(data[0], data[1]);
                    Console.WriteLine(guest.NewGuest());
                }
                else if (data.Length == 3 && int.TryParse(data[2], out int membershipId))
                {
                    memberCount++;
                    Member member = new Member(data[0], data[1], membershipId);
                    Console.WriteLine(member.GetMemberCard(memberCount % 2 == 0 ? "fitness" : "spa"));
                }
                else if (data.Length == 4 && int.TryParse(data[3], out int employeeId))
                {
                    Employee employee = new Employee(data[0], data[1], data[2], employeeId);
                    Console.WriteLine(employee.StartWorkingDay());
                }
            }
        }
    }
}