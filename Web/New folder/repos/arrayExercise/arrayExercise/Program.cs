using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    //Count how many numbers in the array are even and how many are odd.
    public static void countOddEven(int[] count)
    {
        Console.WriteLine("Count how many numbers in the array are even and how many are odd.");
        Console.WriteLine();
        int evenCount = 0;
        int oddCount = 0;

        string evennumbers = "";
        string oddnumbers = "";

        foreach (int i in count)
        {
            if (i % 2 == 0)
            {
                evenCount++;
                evennumbers= evennumbers + i + " ";
                

            }
            else
            {
                oddCount++;
                oddnumbers = oddnumbers + i + " ";

            }
          
        }
        Console.WriteLine(evennumbers);
        Console.WriteLine(evenCount+" "+"Even numbers are in the Array");

        Console.WriteLine(oddnumbers);
        Console.WriteLine(oddCount + " " + "Odd numbers are in the Array");
    }

    //Print only the numbers greater than 25

    public static void showGreater(int[] great)
    {
        Console.WriteLine("Numbers list greater than 25");
        foreach (int num in great)
        {
            if(num>25)
            {
                Console.WriteLine(num);
                }
        }
    }

    //find the smallest number in a list of numbers stored in an array.

    public static void smallestnum(int[] smallnum)
    {
        int count = 0;
        foreach (int num in smallnum)
        {
            count = count + 1;
        }
        Console.WriteLine(count +" "+"numbers in an array");
        Console.WriteLine("Smallest number in the given Array is");
        Console.WriteLine(smallnum.Min());

        Console.WriteLine("Largest number in the given Array is");
        Console.WriteLine(smallnum.Max());

        Console.WriteLine("Sum of  numbers in the given Array is");
        Console.WriteLine(smallnum.Sum());
    }

    //Find duplicate elements in an array

    public static void duplicatenum(int[] dupnum)
    {
        string numduplicate = "";
        for (int i = 0; i < dupnum.Length; i++)
        {
            for(int j = i+1; j < dupnum.Length; j++)
            {
                if(dupnum[j] == dupnum[i])
                {
                    numduplicate=numduplicate+dupnum[i]+" ";
                   
                }
            }

            
        }
        Console.WriteLine("duplicate numbers in the array are" + " " + numduplicate);
    }

    //Search an element in an array

    public static void searchnum(int[] searcharray)
    {
        Console.WriteLine("enter a number you want to search");
        int search = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < searcharray.Length; i++)
        {
            if (searcharray[i] == search)
            {
                Console.WriteLine("I found my number at inddex" +" "+ i);
                return;
            }
        }
        Console.WriteLine("Number not found in the array" );
    }

    //How to sort an array in ascending order

    public static void ascending(int[] ascendingnumbrs)
    {
        Array.Sort(ascendingnumbrs);

        foreach(int num in ascendingnumbrs)
        {
            Console.WriteLine(num);
        }
    }

    //How can you reverse an array using loop
    public static void reversenum(int[] reversenumbrs)
    {
        for(int i=reversenumbrs.Length-1; i>=0; i--)
        {
            Console.WriteLine(reversenumbrs[i]);
        }
    }
    private static void Main(string[] args)
    {
        int[] numbers = { 50, 1, 45, 57, 60, 24, 13, 100,5,45,60,57 };

        //countOddEven(numbers);
        //showGreater(numbers);
        //smallestnum(numbers);
        duplicatenum(numbers);
        //searchnum(numbers);
        //ascending(numbers);
        //reversenum(numbers);
    }
}

   
