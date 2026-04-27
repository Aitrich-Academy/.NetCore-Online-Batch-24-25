using System;

struct JobProvider
{
    public string Email;
    public string Password;
}

class JobProviderApp
{
    static void Main()
    {
        JobProvider[] users = new JobProvider[5]; // Array can hold 5 users
        int userCount = 0; // Number of registered users
        bool isLoggedIn = false;

        char choice;
        do
        {
            Console.WriteLine("\nJob Provider Application Menu:");
            Console.WriteLine("1 - Register");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Exit");

            Console.Write("Enter choice: ");
            choice = Console.ReadLine()[0];

            switch (choice)
            {
                case '1': // Register new user
                    if (userCount < users.Length)
                    {
                        JobProvider newUser = new JobProvider();

                        Console.Write("Enter Email: ");
                        newUser.Email = Console.ReadLine();

                        Console.Write("Enter Password: ");
                        newUser.Password = Console.ReadLine();

                        users[userCount] = newUser;
                        userCount++;
                        Console.WriteLine("Registration successful!");
                    }
                    else
                    {
                        Console.WriteLine("User list is full.");
                    }
                    break;

                case '2': // Login
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    isLoggedIn = false; // Start assuming not logged in

                    // Check all users
                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i].Email == email && users[i].Password == password)
                        {
                            isLoggedIn = true;
                            break;
                        }
                    }

                    if (isLoggedIn)
                        Console.WriteLine("Login successful! Welcome.");
                    else
                        Console.WriteLine("Login failed! Email or password incorrect.");
                    break;

                case '3':
                    Console.WriteLine("Exiting Job Provider Application.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != '3');
    }
}
