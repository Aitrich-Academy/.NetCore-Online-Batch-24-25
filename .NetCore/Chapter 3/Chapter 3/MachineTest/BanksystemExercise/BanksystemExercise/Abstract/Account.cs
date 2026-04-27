using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemExercise.Abstract
{
    internal abstract class Account
    {
        private string Accountholder;
       

        private decimal Newbalance;

        public string AccountHolder
            {
            get { return Accountholder; }
            set { Accountholder = value; }
            
            }

        //public decimal BAlance
        //{
        //    get { return Balance; }
        //    set { Balance = value; }

        //}

        public decimal New_Balance
        {
            get { return Newbalance; }
            set { Newbalance= value; }
        }

        public Account(string accountholder, decimal newbalance)
        {
            Accountholder = accountholder;
            Newbalance = newbalance;
         
            //Balance=balance;
        }

        public abstract void CalculateInterest();
       
    }
}
