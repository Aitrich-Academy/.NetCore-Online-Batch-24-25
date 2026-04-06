internal class Program
{
    struct Car
    {
        public string Brand;
        public string Model;
        public int Year;

        public void Display()
        {
            Console.WriteLine("Car brand:"+" "+Brand);
            Console.WriteLine("Car model:" + " " + Model);
            Console.WriteLine("Car year:" + " " + Year);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        Car car1 = new Car();
        Console.WriteLine("Enter the car brand:");
        car1.Brand = Console.ReadLine();
        Console.WriteLine("Enter the car model:");
        car1.Model = Console.ReadLine();
        Console.WriteLine("Enter the car Year:");
        car1.Year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("car1 Details");
        car1.Display();

        //Car2 details
        Car car2 = new Car();
        car2.Brand = "abc";
        car2.Model = "ghj";
        car2.Year = 1995;
        Console.WriteLine("car2 Details");
        car2.Display();

    }
}