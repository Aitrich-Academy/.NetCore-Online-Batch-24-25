internal class Program
{
    struct Account
    {
        public string Name;
        public string Accountnumber;
        public double Balance;

        public void Display()
        {
            Console.WriteLine("Account holder Name:" + " " + Name);
            Console.WriteLine("Account Number:" + " " + Accountnumber);
            Console.WriteLine("Account Balance:" + " " + Balance);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        Account account1 = new Account();
        Console.WriteLine("AccountHolder name:");
        account1.Name = Console.ReadLine();
        Console.WriteLine("Account Number:");
        account1.Accountnumber = Console.ReadLine();
        Console.WriteLine("balance:");
        account1.Balance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Account1 Details");
        account1.Display();

        //Account2 details
       Account account2 = new Account();
        account2.Name = "chinnu";
        account2.Accountnumber = "021547896544";
        account2.Balance = 1245.00;
        Console.WriteLine("account2 Details");
        account2.Display();

    }
}