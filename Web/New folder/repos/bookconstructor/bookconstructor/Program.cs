internal class Program
{

    struct Book
    {
        public string Title;
        public string Author;
        public double Price;

        public Book(string title, string author,double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }


        public void Display()
        {
            Console.WriteLine("Title:"+" "+Title);
            Console.WriteLine("Author:" +" "+ Author);
            Console.WriteLine("Price:" +" "+ Price);
        }

    }

    private static void Main(string[] args)
    {
       
    Book book1 = new Book("Wings","David",250);//object book1 created using new keyword. Book() call constructor while create object
     book1.Display();
        


    }
}