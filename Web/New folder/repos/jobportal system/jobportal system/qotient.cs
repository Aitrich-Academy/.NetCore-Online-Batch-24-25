using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class qotient
    {
        public static void quotient()
        {
            Console.WriteLine("enter a num1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a num2");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum=num1 + num2;
            int product = num1 * num2;
            int difference = num1 - num2;
            int qu = num1 / num2;
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("product=" + product);
            Console.WriteLine("difference=" + difference);
            Console.WriteLine("quotient=" + qu);
        }
    }
}
