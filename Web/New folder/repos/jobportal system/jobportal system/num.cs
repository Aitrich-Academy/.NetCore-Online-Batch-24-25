using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class num
    {
        public static void printnum()
        {
            string answer;

            do
            {
                for (int i = 1; i <=10; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("do you want to continue? Yes/No:");
                 answer = Console.ReadLine();


            } while (answer == "yes");
            Console.WriteLine("Ended.");

        }

    }
}
