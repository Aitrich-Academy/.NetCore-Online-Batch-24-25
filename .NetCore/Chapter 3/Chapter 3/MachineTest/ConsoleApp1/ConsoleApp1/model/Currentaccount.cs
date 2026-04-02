using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    internal class Currentaccount:Account
    {
        private decimal MaintenanceFee = 10.00m;

        public Currentaccount(string accountHolder, decimal balance): base(accountHolder, balance)
        {

        }

        public override void CalculateInterest()
        {
            Console.WriteLine("No interest for current account");
        }

        public void ApplyMaintenanceFee()
        {
            Balance-=MaintenanceFee;
            Console.WriteLine($"Maintenance fee of {MaintenanceFee} deducted. New Balance:{Balance}");
        }
    }
}
