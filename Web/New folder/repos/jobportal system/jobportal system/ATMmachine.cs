using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class ATMmachine
    {
        public static void atm()
        {
            int balance = 1000;
            string repeatwithdraw = "yes";

            Console.WriteLine("WELCOME TO Handelson Bank ATM");


            while (repeatwithdraw == "yes" && balance > 0)
            {
                Console.WriteLine("Enter amount to withdraw or 0 to Exit");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount == 0)
                {
                   
                    break;
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient balace");
                    Console.WriteLine("Your current balance is:" + balance);

                }
                else if (amount <0)
                {
                    Console.WriteLine("enter positive value");


                }
                else
                {
                   
                    balance = balance - amount;
                    Console.WriteLine("You withdraw:" + amount);
                    Console.WriteLine("your new balance:" + balance);

                }
                if (balance == 0)
                {
                    Console.WriteLine("your account is empty");

                }
                Console.WriteLine("do you have another withdrawal yes/no:");
                repeatwithdraw = Console.ReadLine();
            }
                

              
             
            Console.WriteLine("Your current balance is" + balance);
            Console.WriteLine("Thank You for using , Stay Healthy");


        }
    }
}
