using BanksystemExercise.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemExercise.Model
{
    internal class Currentaccount:Account
    {
        public decimal MonthlyFee = 10.00m;

        public Currentaccount(string accountholder,decimal newbalance) : base(accountholder, newbalance)  
        {

        }

        public override void CalculateInterest()
        {
            Console.WriteLine("Current account does not earn Interest");
        }

        public void ApplyMaintenanceFee()
        {
            New_Balance -= MonthlyFee;
          Console.WriteLine("BAlance after deducting Maintenance Fee:"+" "+New_Balance);
            Console.WriteLine(".......................................");
        }
    }
}
