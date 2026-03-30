using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class greet
    {
        public static void greeting()
        {
            Console.WriteLine("Enter your name");
            string greetname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello" + greetname);

        }
    }
}
