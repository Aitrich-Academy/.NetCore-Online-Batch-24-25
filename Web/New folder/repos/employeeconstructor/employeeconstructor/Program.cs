internal class Program
{
    struct Employee
    {
        public string Empname;
        public int Empid;
        public double Empsalary;

        //public Employee(string name,int id,double salary)
        //{
        //    Empname = name; 
        //    Empid = id; 
        //    Empsalary = salary;
        //}

        public void Display()
        {
            Console.WriteLine("Name of Employee:"+" "+Empname);
            Console.WriteLine("Id of Employee:" + " " + Empid);
            Console.WriteLine("Salary of Employee:" + " " + Empsalary);
            Console.WriteLine();
        }

    }
 

    private static void Main(string[] args)
    {
        //Console.WriteLine("enter employee name");
        //string name=Console.ReadLine();
        //Console.WriteLine("enter employee id:");
        //int id=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("enter salary:");
        //double salary=Convert.ToDouble(Console.ReadLine());

        //Employee emp = new Employee(name,id,salary);
        //emp.Display();

        Employee emp1 = new Employee();
        emp1.Empname = "chinnu";
        emp1.Empid = 5;
        emp1.Empsalary = 1000;

        emp1.Display();

        Employee emp2 = new Employee();
        emp2.Empname = "David";
        emp2.Empid = 10;
        emp2.Empsalary = 2000;

        emp2.Display();

        Employee emp3 = new Employee();
        emp3.Empname = "Honey";
        emp3.Empid = 25;
        emp3.Empsalary = 5000;

        emp3.Display();




    }
}