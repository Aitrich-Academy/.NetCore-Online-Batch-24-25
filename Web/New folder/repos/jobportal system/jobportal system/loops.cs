using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class loops
    {
        public static void fruits()
        {
            Console.Write("Enter your favorite fruit: ");
            string fruit = Console.ReadLine(); 

            switch (fruit)
            {
                case "apple":
                    Console.WriteLine("Apple is my favourite fruit");
                    break;

                case "banana":
                    Console.WriteLine("Banana is my favourite fruit");
                    break;

                case "mango":
                    Console.WriteLine("Mango is my favourite fruit");
                    break;

                case "orange":
                    Console.WriteLine("Orange is my favourite fruit");
                    break;

                case "grape":
                    Console.WriteLine("Grapes is my favourite fruit");
                    break;

                default:
                    Console.WriteLine("That’s a unique choice");
                    break;
            }
        }
    }
}
