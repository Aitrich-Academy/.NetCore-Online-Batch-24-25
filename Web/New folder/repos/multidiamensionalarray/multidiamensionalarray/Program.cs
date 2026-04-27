internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        int[,] nums = new int[2, 3];

        nums[0,0] = 10;
        nums[0,1] = 20;
        nums[0,2] = 30;
        nums[1, 0] = 40;
        nums[1, 1] = 50;
        nums[1, 2] = 60;
       

        for (int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write(nums[i,j]+" ");

                sum = sum + nums[i, j];

            }
            Console.WriteLine();
        }
        Console.WriteLine(sum);

    }
}