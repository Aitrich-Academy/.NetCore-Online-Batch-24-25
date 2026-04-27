using BanksystemExercise.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemExercise.Model.Savingsaccount
{
    internal class Savingsaccount : Account
    {
        private decimal interestrate = 0.05m;

        public Savingsaccount(string accountholder,decimal newbalance) : base(accountholder, newbalance)
        {

        }

        public override void CalculateInterest()
        {
            decimal interest=New_Balance*interestrate;
            New_Balance += interest;
            Console.WriteLine("Now your Balanceis:" + " " + New_Balance);
            Console.WriteLine(".......................................");
        }

    }
}
