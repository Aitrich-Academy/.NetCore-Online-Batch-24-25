using System;
namespace jobportal_system
{
    internal class area
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter length");
            double length=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width"); 
            double width=Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("Area of the rectangle:" + area);
        }
          
    }
}
