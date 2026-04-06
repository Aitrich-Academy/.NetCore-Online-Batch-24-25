using System.Collections.Specialized;

internal class Program

{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,

    }
    struct Appoinment
    {
        public string Patientame;
        public string Doctorname;
        public string Date ;
        public string Time;
        public Days Day;

        public Appoinment(string patientname, string doctorname,string date, string time,Days day)
        {
            Patientame = patientname;
            Doctorname = doctorname;
            Date = date;
            Time = time;
            Day = day;
        }
        public void Display()
        {
            Console.WriteLine("Patient Name:" + " " + Patientame);
            Console.WriteLine("Doctor Name:" + " " + Doctorname);
            Console.WriteLine("date:" + " " + Date);
            Console.WriteLine("Time:" + " " + Time);
            Console.WriteLine("Day:" + " " + Day);
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
       
        Console.WriteLine("patient1 name:");
        string patientame = Console.ReadLine();
        Console.WriteLine("Doctor name:");
        string doctorname = Console.ReadLine();
        Console.WriteLine("Date:");
        string date= Console.ReadLine();
        Console.WriteLine("Time:");
        string time = Console.ReadLine();
        Console.WriteLine("Enter Day:");
        string dayinput= Console.ReadLine();

        Days days=(Days)Enum.Parse(typeof(Days), dayinput,true);

        Appoinment appoinment1 = new Appoinment(patientame,doctorname,date,time,days);

        Console.WriteLine();
        Console.WriteLine("Patient1 Details");
        appoinment1.Display();

        Console.WriteLine("patient2 name:");
        string patientame1 = Console.ReadLine();
        Console.WriteLine("Doctor name:");
        string doctorname1 = Console.ReadLine();
        Console.WriteLine("Date:");
        string date1 = Console.ReadLine();
        Console.WriteLine("Time:");
        string time1 = Console.ReadLine();
       
        Console.WriteLine("Enter Day:");
        string dayinput1 = Console.ReadLine();

        Days days1 = (Days)Enum.Parse(typeof(Days), dayinput1,true);

        Appoinment appoinment2 = new Appoinment(patientame1, doctorname1, date1, time1,days1);

        Console.WriteLine();
        Console.WriteLine("Patient2 Details");
        appoinment2.Display();

        Console.WriteLine("patient3 name:");
        string patientame2 = Console.ReadLine();
        Console.WriteLine("Doctor name:");
        string doctorname2 = Console.ReadLine();
        Console.WriteLine("Date:");
        string date2 = Console.ReadLine();
        Console.WriteLine("Time:");
        string time2 = Console.ReadLine();
        Console.WriteLine("Enter Day:");
        string dayinput2 = Console.ReadLine();

        Days days2 = (Days)Enum.Parse(typeof(Days), dayinput2,true);
        Appoinment appoinment3 = new Appoinment(patientame2, doctorname2, date2, time2,days2);

        Console.WriteLine();
        Console.WriteLine("Patient3 Details");
        appoinment3.Display();
    }
}