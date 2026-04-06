using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;

        int[,] nums = new int[2, 3];

        //Console.WriteLine("enter the value for position[0,0]");
        //nums[0,0]=Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("enter the value for position[0,1]");
        //nums[0, 1] = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("enter the value for position[0,2]");
        //nums[0, 2] = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("enter the value for position[1,0]");
        //nums[1, 0] = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("enter the value for position[1,1]");
        //nums[1, 1] = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("enter the value for position[1,2]");
        //nums[1, 2] = Convert.ToInt32(Console.ReadLine());

        for(int i=0;i<2;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.WriteLine("Enter the value for the position" + "["+i+"]"+"["+j+"]");
                nums[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        Console.WriteLine("2 x 3 matrix is");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum=sum+nums[i,j];
                Console.Write(nums[i,j]+" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("sum of the numbrs in the mmatrix is" + " " + sum);


    }
}
