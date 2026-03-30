internal class Program
{
    struct Movie
    {
        public string Name;
        public string Genre;
        public int Duration;

        public void Display()
        {
            Console.WriteLine("Film Name:" + " " + Name);
            Console.WriteLine("Film Genre:" + " " + Genre);
            Console.WriteLine("Film Duration:" + " " + Duration);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
      Movie movie1 = new Movie();
        Console.WriteLine("Enter movie name:");
        movie1.Name = Console.ReadLine();
        Console.WriteLine("Enter the movie Genre:");
        movie1.Genre = Console.ReadLine();
        Console.WriteLine("Enter the duration:");
        movie1.Duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("movie1 Details");
        movie1.Display();

        //Car2 details
       Movie movie2 = new Movie();
        movie2.Name = "abcd";
        movie2.Genre = "comedy";
        movie2.Duration = 3;
        Console.WriteLine("Movie2 Details");
        movie2.Display();

    }
}