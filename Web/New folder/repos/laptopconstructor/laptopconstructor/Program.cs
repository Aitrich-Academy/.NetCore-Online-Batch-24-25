internal class Program
{
    struct Laptop
    {
        public string Brand;
        public string Processor;
        public int Ram;

        public void Display()
        {
            Console.WriteLine("Brand:" + " " + Brand);
            Console.WriteLine("Processor:" + " " + Processor);
            Console.WriteLine("RAM:" + " " + Ram);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
      Laptop laptop1 = new Laptop();
        Console.WriteLine("Laptop Brand:");
        laptop1.Brand = Console.ReadLine();
        Console.WriteLine("Procssor:");
        laptop1.Processor = Console.ReadLine();
        Console.WriteLine("RAM:");
        laptop1.Ram = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Laptop1 Details");
        laptop1.Display();

        //laptop2 details
       Laptop laptop2= new Laptop();
        laptop2.Brand = "Dell";
        laptop2.Processor = "Intel Core i5";
        laptop2.Ram = 8;
        Console.WriteLine("Laptop2 Details");
        laptop2.Display();

    }
}