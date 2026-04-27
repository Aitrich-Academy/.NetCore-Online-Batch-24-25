using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class sumnum
    {
        public static void sum()
        {
            Console.WriteLine("Enter first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum=num1 + num2;
            int product = num1 * num2;
            Console.WriteLine("sum of the given numbers:" + sum);
            Console.WriteLine("product of the given numbers:"+product);
          

        }
    }
}
