using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class swap
    {
        public static void swapping()
        {
            int num1 = 10;
            int num2 = 20;
            int temp;
            Console.WriteLine(" before swapping num1=" + " " + num1 +"and num2="+num2);

            temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine(" after swapping num1=" + " " + num1 + "and num2=" + num2);




        }
    }
}
