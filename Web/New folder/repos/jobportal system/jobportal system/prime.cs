using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class prime
    {
        public static void primenumber()
        {
            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 <= 1)
            {
                Console.WriteLine(num1 + "not a prime number");
            }
            else
            {
                for (int i = 2; i < num1; i++)
                {
                    if (num1 % i == 0)
                    {
                        Console.WriteLine(num1 + "not a prime number");
                        return;
                        
                    }
                   

                }
                 
                    Console.WriteLine(num1 + "is a prime number");
                
            }
        }
    }
}
