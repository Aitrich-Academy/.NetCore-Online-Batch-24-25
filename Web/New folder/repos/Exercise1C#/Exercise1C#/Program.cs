using System;

namespace JobPortalWithStructAndArray
{
    struct User
    {
        public string Email;
        public string Password;
        public string Name;
    }

    class Program
    {
        static User[] users = new User[100]; // Fixed array of 100 users
        static int userCount = 0;

        static void Main(string[] args)
        {
            int mainChoice;

            do
            {
                Console.WriteLine("\n=== Job Portal ===");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                mainChoice = Convert.ToInt32(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Exiting application...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (mainChoice != 3);
        }

        static void Register()
        {
            if (userCount >= users.Length)
            {
                Console.WriteLine("User limit reached!");
                return;
            }

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            // Check if email already exists
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Email == email)
                {
                    Console.WriteLine("Email already registered.");
                    return;
                }
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            users[userCount].Email = email;
            users[userCount].Password = password;
            users[userCount].Name = name;
            userCount++;

            Console.WriteLine("Registration successful!\n");
        }

        static void Login()
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Email == email && users[i].Password == password)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine("Login successful!\n");
                ShowMenu(index);
            }
            else
            {
                Console.WriteLine("Invalid email or password.\n");
            }
        }

        static void ShowMenu(int userIndex)
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. List all jobs");
                Console.WriteLine("2. Display profile");
                Console.WriteLine("3. Logout");
                Console.Write("Choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ListJobs();
                        break;
                    case 2:
                        DisplayProfile(userIndex);
                        break;
                    case 3:
                        Console.WriteLine("Logging out...\n");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 3);
        }

        static void ListJobs()
        {
            Console.WriteLine("\nAvailable Jobs:");
            Console.WriteLine("1. Software Developer");
            Console.WriteLine("2. Web Designer");
            Console.WriteLine("3. Data Analyst\n");
        }

        static void DisplayProfile(int index)
        {
            Console.WriteLine($"\nProfile Info:");
            Console.WriteLine($"Name: {users[index].Name}");
            Console.WriteLine($"Email: {users[index].Email}\n");
        }
    }
}
