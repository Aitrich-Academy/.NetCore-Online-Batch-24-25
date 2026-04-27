using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class temperature
    {

         
           public static void temp()
        {
            Console.WriteLine("Enter a temerature value in celcious");
            double temp=Convert.ToDouble(Console.ReadLine());
            double fahren = (temp * 9 / 5) + 32;
            Console.WriteLine(fahren);
        }




        
    }
}
