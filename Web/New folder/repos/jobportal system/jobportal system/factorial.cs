using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class factorial
    {
        public static void fact()
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int factorialnum = 1;
            for (int i = 1; i <= num; i++)
            {
                factorialnum=factorialnum*i;
            }
            Console.WriteLine("factorial of the given number is"+factorialnum);
        }

    }
}
