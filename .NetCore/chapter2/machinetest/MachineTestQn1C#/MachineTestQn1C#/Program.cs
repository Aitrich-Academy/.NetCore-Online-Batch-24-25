internal class Program
{

    struct Patient
    {
        public int ID;
        public string Name;
        public int Age;
    }
    private static void Main(string[] args)
    {
        Patient[] patients = new Patient[5];
        int count = 0;
        string answer;

        Console.WriteLine("WELCOME TO HOSPITAL MANAGEMNET");

        do
        {
            Console.WriteLine("please choose an option");
            Console.WriteLine("1.Enter New Patient Details");
            Console.WriteLine("2. List Patient Details");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    if (count < patients.Length)
                    {
                        Patient patientprofile = new Patient();

                        Console.WriteLine("Enter Patient ID");
                        patientprofile.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Patient Name");
                        patientprofile.Name = Console.ReadLine();
                        Console.WriteLine("Enter Patient Age");
                        patientprofile.Age = Convert.ToInt32(Console.ReadLine());

                        patients[count] = patientprofile;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient storage to hold");
                    }
                    break;

                case "2":

                    Console.WriteLine("Patient Details");

                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("ID of Patient:" + patients[i].ID);
                            Console.WriteLine("Name of Patient:" + patients[i].Name);
                            Console.WriteLine("Age of Patient:" + patients[i].Age);
                            Console.WriteLine();
                        
                        }
                    }
                    else
                    {
                        Console.WriteLine("Patient Details not stored  Yet");
                    }
                    break;









            }
            Console.WriteLine("Do you want to continue yes/no");
            answer = Console.ReadLine();









        }while (answer =="yes");

        Console.WriteLine("Thank you for using Hospital Management");
}
}