using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class avgnum
    {
        public static void avarage()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double avgnum = (num1 + num2) / 2;
            Console.WriteLine("avarage of the given numbers:" + avgnum);


        }
    }
}
