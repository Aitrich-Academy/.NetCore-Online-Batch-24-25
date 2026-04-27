using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class votingage
    {
        public static void voting()
        {
            Console.WriteLine("Enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("you are eligible for voting");
            }
            else
            {
                Console.WriteLine("you are not eligible for vote");
            }


        }
    }
}
