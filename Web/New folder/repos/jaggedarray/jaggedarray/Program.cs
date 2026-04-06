internal class Program
{
    private static void Main(string[] args)
    {
        int[][] jaggedarray = new int[3][];
        {
            jaggedarray[0] = new int[] { 1, 2, 3 };
            jaggedarray[1] = new int[] { 4, 5 };
            jaggedarray[2] = new int[] { 6 };

            Console.WriteLine("array elemets are");

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                foreach(int num  in jaggedarray[i])
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }

    }
}