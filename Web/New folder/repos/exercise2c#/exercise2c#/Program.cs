using System;

struct Member
{
    public int UserID;
    public string Name;
    public string Designation;
    public string Email;
    public string PhoneNumber;
}

class Program
{
    static void Main(string[] args)
    {
        string username = "chinnu";
        string password = "1234";

       
        Member[] members = new Member[5];
        int memberCount = 0;

        // Pre-added members
        members[0].UserID = 1;
        members[0].Name = "John";
        members[0].Designation = "Manager";
        members[0].Email = "john@example.com";
        members[0].PhoneNumber = "1234567890";

        members[1].UserID = 2;
        members[1].Name = "Sarah";
        members[1].Designation = "Engineer";
        members[1].Email = "sarah@example.com";
        members[1].PhoneNumber = "0987654321";

        memberCount = 2;

        Console.WriteLine(" Job Provider Login ");
        Console.Write("Enter username: ");
        string inputUser = Console.ReadLine();

        Console.Write("Enter password: ");
        string inputPass = Console.ReadLine();

        if (inputUser == username && inputPass == password)
        {
            Console.WriteLine("Login Successful!");

            string choice;
            do
            {
                Console.WriteLine("\n===== Main Menu =====");
                Console.WriteLine("1. View Company Members");
                Console.WriteLine("2. Add Company Member");
                Console.WriteLine("3. Logout");
                Console.Write("Select an option (1-3): ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Here are the Company Members ");
                        for (int i = 0; i < memberCount; i++)
                        {
                            Console.WriteLine("\nMember " + (i + 1));
                            Console.WriteLine("User ID: " + members[i].UserID);
                            Console.WriteLine("Name: " + members[i].Name);
                            Console.WriteLine("Designation: " + members[i].Designation);
                            Console.WriteLine("Email: " + members[i].Email);
                            Console.WriteLine("Phone Number: " + members[i].PhoneNumber);
                        }
                        break;

                    case "2":
                        if (memberCount < members.Length)
                        {
                            Console.WriteLine("\nEnter New Member Details:");

                            Console.Write("User ID: ");
                            members[memberCount].UserID = int.Parse(Console.ReadLine());

                            Console.Write("Name: ");
                            members[memberCount].Name = Console.ReadLine();

                            Console.Write("Designation: ");
                            members[memberCount].Designation = Console.ReadLine();

                            Console.Write("Email: ");
                            members[memberCount].Email = Console.ReadLine();

                            Console.Write("Phone Number: ");
                            members[memberCount].PhoneNumber = Console.ReadLine();

                            memberCount++;
                            Console.WriteLine("New member added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add more members. Maximum limit reached.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Logging out...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != "3");
        }
        else
        {
            Console.WriteLine("\nInvalid username or password. Program will now exit.");
        }

        Console.WriteLine("\nThank you for using the Job Provider Application.");
    }
}
