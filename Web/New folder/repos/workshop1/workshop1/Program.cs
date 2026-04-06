internal class Program
{
    struct Admin
    {
        public string Name;
        public string Username;
        public string Email;
        public long Phonenumber;
    }
    private static void Main(string[] args)
    {
        Admin[] adminarray = new Admin[5];
        int Count = 0;
        string continuechoice;


        Console.WriteLine("WELCOME TO ADMIN PROFILE");

        do
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("Option A: Register Admin");
            Console.WriteLine("Option B: List Admin details");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "A":
                    if (Count < adminarray.Length)
                    {
                        Admin adminprofile = new Admin();

                        Console.Write("Enter admin Name:");
                        adminprofile.Name = Console.ReadLine();
                        Console.Write("Enter Username:");
                        adminprofile.Username = Console.ReadLine();
                        Console.Write("Enter Email:");
                        adminprofile.Email = Console.ReadLine();
                        Console.Write("Enter admin phonenumber:");
                        adminprofile.Phonenumber = Convert.ToInt64(Console.ReadLine());

                        adminarray[Count] = adminprofile;
                        Count++;




                    }
                    else
                    {
                        Console.WriteLine("Insufficient storage");
                    }
                    break;

                case "B":

                    Console.WriteLine("Admin Details");

                    if (Count > 0)
                    {
                        for (int i = 0; i < Count; i++)
                        {
                            Console.WriteLine("Name of Admin:" + adminarray[i].Name);
                            Console.WriteLine("Username of Admin:" + adminarray[i].Username);
                            Console.WriteLine("Email of Admin:" + adminarray[i].Email);
                            Console.WriteLine("Phonenumber of Admin:" + adminarray[i].Phonenumber);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Admin not registered yet");
                    }



                    break;

            }

            Console.WriteLine("Do you want to continue:yes/no");
            continuechoice = Console.ReadLine();


        } while (continuechoice == "yes");


        Console.WriteLine("Thank you for using Admin Profile");

    }
}