using BanksystemExercise.Model.Savingsaccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemExercise.Manager
{
    internal class Savingsaccountdata
    {
        Savingsaccount[] savingsarray = new Savingsaccount[2];
        public int count = 0;
        int minbal = 1000;
        private decimal Balance = 2000;


        public void SavingsDetails()
        {
            Console.Write("Enter AccountHolder Name:");
            string accountholder=Console.ReadLine();
            //Console.Write("Enter your Balance:");
            //decimal balance= Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How much you want to deposit");
            decimal deposit=Convert.ToDecimal(Console.ReadLine());

            if(count==savingsarray.Length)
            {
                Console.WriteLine("There is no space to store details");
                Console.WriteLine(".......................................");
            }
            else
            {
                decimal newbalance = Balance + deposit;
                Savingsaccount savings = new Savingsaccount(accountholder,newbalance);
             
                savingsarray[count] = savings;
                count++;
               
                

                if (Balance>1000)
                {
                    Console.WriteLine("Congratulations you have enough balance to continue");
                    Console.WriteLine();
                    Console.WriteLine("Your New Balance is:" + " " + newbalance);
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine("Do you want to chcek Balance after calculating interest rate:");
                    Console.WriteLine("1.yes");
                    Console.WriteLine("2.no");
                    Console.WriteLine(".......................................");
                    string answer=Console.ReadLine().Trim(); 

                    switch(answer)
                    {
                        case "1":
                            
                            savings.CalculateInterest();
                            break;
                        case "2":


                            Console.WriteLine("return main menu");
                            return;


                    }

                }
                else
                {
                    Console.WriteLine("You have no minimum balance try again later");
                    Console.WriteLine(".......................................");
                    return;
                }
            }


        }


      
    }
}
