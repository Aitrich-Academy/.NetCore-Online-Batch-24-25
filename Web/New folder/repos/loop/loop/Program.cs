using System;
internal class Program
{

    public static int sumnum(int num1,int num2)
    {
        return num1+num2;
      

    }

    private static void Main(string[] args)
    {
       int sum= sumnum(4, 5);
        Console.WriteLine(sum);
       
    }
}