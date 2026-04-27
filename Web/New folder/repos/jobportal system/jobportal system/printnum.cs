using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class printnum
    {
        public static void numbers()
        {
            for(int i = 1;i<=100;i++)
            {
               if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
