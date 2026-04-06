using BanksystemExercise.Manager;
using BanksystemExercise.Manager.Crrentaccount;
using BanksystemExercise.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("wELCOME TO BANKING SYSTEM");
        Console.WriteLine(".............................");
        string input = "";

        do
        {
            Console.WriteLine("Which Account you have? ");
            Console.WriteLine("Please select an Option");
            Console.WriteLine("1.SAVINGS");
            Console.WriteLine("2.CURRENT");
            Console.WriteLine("3.EXIT");

             input = Console.ReadLine();

            Console.WriteLine();


            switch (input)
            {
                case "1":
                    Savingsaccountdata saving =new Savingsaccountdata();
                    saving.SavingsDetails();
                    break;
                case "2":
                   Crrentaccountdata current = new Crrentaccountdata();
                    current.CurrentDetails();
                    break;
                case "3":
                    Console.WriteLine("Good Bye");
                    return;
            }

        } while (input != "3");
    }
}