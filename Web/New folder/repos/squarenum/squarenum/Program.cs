internal class Program
{
    public static int square(int x)
    {
        return x * x;
        
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num=Convert.ToInt32(Console.ReadLine());
        int result=square(num);
        Console.WriteLine(result);
    }
}