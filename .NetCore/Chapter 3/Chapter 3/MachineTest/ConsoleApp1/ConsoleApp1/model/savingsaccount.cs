using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp1.model
{
    internal class savingsaccount:Account
    {
        private decimal InterestRate = 0.05m;

        public savingsaccount(string accountHolder, decimal balance) : base(accountHolder, balance)
        {

        }
        public override void CalculateInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest of{interest} added.  New balance is:{Balance}");
        }


    }
}
