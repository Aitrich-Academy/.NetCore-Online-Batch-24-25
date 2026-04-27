using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Account
{
    public string AccountHolder {  get; set; }
    public decimal Balance { get; set; }

    public Account(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }


    public abstract void CalculateInterest();


}

}

