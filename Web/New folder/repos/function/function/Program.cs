using System.Numerics;

internal class Program
{
    static void Display()
    {
        Console.WriteLine("Arithmetic operations");
    }
    public static void multiply(int x, int y)
    {
        int product = x * y;
        Console.WriteLine("product of two given numbers"+""+product);
    }

    public static void addition(int x, int y)
    {
        int sum=x+ y;
        Console.WriteLine("sum of two given numbers:" + "" + sum);
    }

    public static void subtraction(int x, int y)
    {
        int subtration=x-y;
        Console.WriteLine("subtraion of two given numbers:" + "" + subtration);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number1:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter a number2:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        multiply(num1, num2);
        addition(num1, num2);
        subtraction(num1, num2);
        
    }
}