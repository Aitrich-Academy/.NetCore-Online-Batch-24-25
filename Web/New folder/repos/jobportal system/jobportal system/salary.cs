using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class salary
    {
        public static void creditcard()
        {
            double minsalary = 2000;
            Console.WriteLine("enter your salary");
            double usersalary=Convert.ToDouble(Console.ReadLine());
            if (usersalary >= minsalary)
            {
                Console.WriteLine("you are eligible for credit card");
            }
            else
            {
                Console.WriteLine("you are not eligible for credit card");
            }
        }
    }
}
