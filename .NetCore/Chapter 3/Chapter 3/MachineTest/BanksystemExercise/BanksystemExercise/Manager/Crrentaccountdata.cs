using BanksystemExercise.Model;
using BanksystemExercise.Model.Savingsaccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemExercise.Manager.Crrentaccount
{
    internal class Crrentaccountdata
    {
        Currentaccount[] currentarray = new Currentaccount[3];
        public int count = 0;
        int minbal = 1000;

        private decimal Balance = 1500;


        public void CurrentDetails()
        {
            Console.Write("Enter AccountHolder Name:");
            string accountholder = Console.ReadLine();
            //Console.Write("Enter your Balance:");
            //decimal balance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How much you want to deposit");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            if (count == currentarray.Length)
            {
                Console.WriteLine("There is no space to store details");
                Console.WriteLine(".......................................");
            }
            else
            {
                decimal newbalance = Balance + deposit;
                Currentaccount currents = new Currentaccount(accountholder, newbalance);

                currentarray[count] = currents;
                count++;


                if (Balance > 1000)
                {
                    Console.WriteLine("Congratulations you have enough balance to continue");
                    Console.WriteLine();
                    Console.WriteLine("Your New Balance is:" + " " + newbalance);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to chcek Balance after deducting maintenance fee:");
                    Console.WriteLine("1.yes");
                    Console.WriteLine("2.no");
                    Console.WriteLine();
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":

                            currents.ApplyMaintenanceFee();
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

