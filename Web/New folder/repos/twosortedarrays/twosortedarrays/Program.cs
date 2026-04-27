using System;
using System.Linq;
    

class Program
{
    static void Main()   
    {
        int[] array1 = { 1, 3, 2 };  
        int[] array2 = { 7, 5, 6 }; 
       



        int[] merged = array1.Concat(array2).ToArray();

        Array.Sort(merged);
        Console.WriteLine("sorted and merged array is ");

        foreach (int i in merged)
        {
           
            Console.Write(i+",");
        }


    }
}