internal class Program
{
    public enum Gender
    {
      male,
       female,
       others,
    }
        public struct Student
    {
        public int age;
        public string name;
        public Gender gender;

        public Student(int studentage, string studentame,Gender studentgender)
        {
            age = studentage;
            name = studentame;
            gender = studentgender;
        }
        public void display()
        {
            Console.WriteLine("student name:" + name);
            Console.WriteLine("student age:" + age);
            Console.WriteLine("student gender:" + gender);

        }
    }

    private static void Main(string[] args)
    {
        Student student1 = new Student(25,"Honey",Gender.female);
        student1.display();

        Student student2 = new Student(30, "Dibin", Gender.male);
        student2.display();

        //student 3 Details
        Console.WriteLine("student3 Name:");
        string studentname = Console.ReadLine();
        Console.WriteLine("student3 Age:");
        int studentage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("student3 Gender:");
        string genderinput = Console.ReadLine();


        Gender studentgender=(Gender)Enum.Parse(typeof(Gender),genderinput);
        Student student3 = new Student(studentage, studentname, studentgender);
        student3.display();

    }
}