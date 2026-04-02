using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class numbertype
    {
        public static void num()
        {
            Console.WriteLine("Enter  number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
        }
    }
}
