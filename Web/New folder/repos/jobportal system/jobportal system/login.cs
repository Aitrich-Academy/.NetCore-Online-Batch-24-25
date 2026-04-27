using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class login
    {
        public static void log()
        {
            string password = "password123";
            int startattempt = 0;
            int maxattempt = 3;

            while (startattempt < maxattempt)
            {
                Console.WriteLine("Enter your password:");
                string getpassword = Console.ReadLine();
                startattempt++; 

                if (getpassword == password)
                {
                    Console.WriteLine("Congratulations!!!");
                    Console.WriteLine("LOGIN SUCCESSFUL!!!!!!");
                    return;
                }

                
                if (getpassword.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters long.");
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                }

                
                int remainingattempt = maxattempt - startattempt;
                if (remainingattempt > 0)
                {
                    Console.WriteLine("You have " + remainingattempt + " attempt left.");
                }
            }

            Console.WriteLine("You have exceeded the maximum number of login attempts.");
        }
    }
}
