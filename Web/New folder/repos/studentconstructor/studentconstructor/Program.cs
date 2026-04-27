internal class Program
{
    struct Student
    {
        public string Name;
        public int Age;
        public int Mark1,Mark2;

        public Student(string name,int age,int mark1,int mark2)
        {
            Name = name;
            Age = age;
            Mark1 = mark1;
            Mark2 = mark2;

        }
        public void Display()
        {
            Console.WriteLine("Name:"+" "+Name);
            Console.WriteLine("Age:" + " " + Age);
            Console.WriteLine("Mark1:" + " " + Mark1);
            Console.WriteLine("Mark2:" + " " + Mark2);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("enter stdent1 name:");
        string name=Console.ReadLine();
        Console.WriteLine("enter student1 age");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter student1 mark1");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter student1 mark2");
        int mark2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("student1 details:");

        Student student1=new Student(name,age,mark1,mark2);
        student1.Display();

        Student student2=new Student();
        student2.Name = "Honey";
        student2.Age = 30;
        student2.Mark1 = 100;
        student2.Mark2 = 200;

        student2.Display();


        Student student3=new Student();
        Console.WriteLine("Enter student3 name:");
        student3.Name=Console.ReadLine();
        Console.WriteLine("Enter student3 age:");
        student3.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student3 mark1:");
        student3.Mark1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student3 mark2:");
        student3.Mark2 = Convert.ToInt32(Console.ReadLine());

        student3.Display();

    }
}