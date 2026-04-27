using System;

namespace InterviewScheduler
{
    struct Interview
    {
        public string JobTitle;
        public string Date;
        public string Time;
        public string Location;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Interview[] interviews = new Interview[10]; 
            int count = 0;
            char choice;
            string answer;

            do
            {
                Console.WriteLine(" Interview Schedule Management");
                Console.WriteLine("A - Schedule an Interview");
                Console.WriteLine("D - Display Scheduled Interviews");
              
                Console.Write("Enter your choice: ");
                choice = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                switch (choice)
                {
                    case 'A':
                        if (count < interviews.Length)
                        {
                            Interview newInterview=new Interview();

                            Console.Write("Enter Job Title: ");
                            newInterview.JobTitle = Console.ReadLine();

                            Console.Write("Enter Date : ");
                            newInterview.Date = Console.ReadLine();

                            Console.Write("Enter Time : ");
                            newInterview.Time = Console.ReadLine();

                            Console.Write("Enter Location: ");
                            newInterview.Location = Console.ReadLine();

                            interviews[count] = newInterview;
                            count++;

                            Console.WriteLine("Interview scheduled successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Interview list is full.");
                        }
                        break;

                    case 'D':
                        Console.WriteLine("\n--- Scheduled Interviews ---");
                        if (count == 0)
                        {
                            Console.WriteLine("No interviews scheduled yet.");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"\nInterview #{i + 1}");
                                Console.WriteLine($"Job Title: {interviews[i].JobTitle}");
                                Console.WriteLine($"Date: {interviews[i].Date}");
                                Console.WriteLine($"Time: {interviews[i].Time}");
                                Console.WriteLine($"Location: {interviews[i].Location}");
                            }
                        }
                        break;

                  
                }

                Console.Write("Do you want to continue? (Y/N): ");
                answer = Console.ReadLine().ToUpper();

            } while (answer == "Y");
        }
    }
}
