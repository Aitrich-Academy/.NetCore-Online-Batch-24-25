internal class Program
{
    struct Product
    {
        public int Productid;
        public string Productname;
        public double Productprice;

        public Product(int productid, string productname,double productprice)
        {
            Productid = productid;
            Productname = productname;
            Productprice = productprice;

        }
        public void Display()
        {
            Console.WriteLine("Product ID:" + " " + Productid);
            Console.WriteLine("Product Name:" + " " + Productname);
            Console.WriteLine("Product Price:" + " " + Productprice);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter product id:");
        int id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter product price:");
        double price = Convert.ToDouble(Console.ReadLine());

        Product product = new Product(id,name,price);
        product.Display();


    }
}