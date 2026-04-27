internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---- First() ----");
        var firstList = new List<int> { 10 };
        Console.WriteLine("First element: " + firstList.Last());

        //var emptyFirstList = new List<string>();
        //Console.WriteLine(emptyFirstList.First()); // ❌ InvalidOperationException

        var numbers = new List<int> { 4, 6, 8 };

        Console.WriteLine("---- First Odd ----");
        int firstOdd = numbers.First(n => n % 2 != 0);
        Console.WriteLine("First odd: " + firstOdd); // Output: 9

        Console.WriteLine("\n---- First Even ----");
        int firstEven = numbers.First(n => n % 2 == 0);
        Console.WriteLine("First even: " + firstEven); // Output: 4


        Console.WriteLine("\n---- FirstOrDefault() ----");
        var firstOrDefaultList = new List<int> { 100, 200 };
        Console.WriteLine("FirstOrDefault: " + firstOrDefaultList.FirstOrDefault());

        var emptyFirstOrDefaultList = new List<string>();
        Console.WriteLine("FirstOrDefault on empty: " + emptyFirstOrDefaultList.FirstOrDefault());


    }
}