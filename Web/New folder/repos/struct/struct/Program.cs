internal class Program
{
    struct book
    {
        public string Title;
        public string Author;
        public double Price;

        //public book(string title, string author, double price)
        //{
        //    Title = title;
        //    Author = author;
        //    Price = price;
        //}



        public void display()
        {
            Console.WriteLine("Book details");
            Console.WriteLine("Title"+Title);
            Console.WriteLine("Author " + Author);
            Console.WriteLine("Price" + Price);
        }
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("Enter book Title");
        //string title = Console.ReadLine();
        //Console.WriteLine("Enter book author");
        //string author = Console.ReadLine();
        //Console.WriteLine("Enter book Price");
        //double price = Convert.ToDouble(Console.ReadLine());


        //book newbook = new book(title, author, price);
        //newbook.display();

        book newbook;
        Console.WriteLine("Title of the book");
        newbook.Title = Console.ReadLine();
        Console.WriteLine("author of the book");
        newbook.Author = Console.ReadLine();
        Console.WriteLine("price of the book");
        newbook.Price = Convert.ToDouble(Console.ReadLine());


        book book1;
        Console.WriteLine("Title of the book");
        book1.Title = Console.ReadLine();
        Console.WriteLine("author of the book");
        book1.Author = Console.ReadLine();
        Console.WriteLine("price of the book");
        book1.Price = Convert.ToDouble(Console.ReadLine());


        newbook.display();
        book1.display();



    }
}