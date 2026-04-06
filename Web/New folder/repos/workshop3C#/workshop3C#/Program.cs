using System;

namespace JobPostingPlatform
{
    struct Job
    {
        public string JobTitle;
        public string Company;
        public string Location;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Job[] jobs = new Job[10];
            int count = 0;
            string choice;
            string continueAnswer;

            do
            {
                Console.WriteLine(" Job Posting Platform ");
                Console.WriteLine("A - Post a Job");
                Console.WriteLine("D - View Posted Jobs");

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "A":
                        if (count < jobs.Length)
                        {
                            Job newJob = new Job();

                            Console.Write("Enter Job Title: ");
                            newJob.JobTitle = Console.ReadLine();

                            Console.Write("Enter Company Name: ");
                            newJob.Company = Console.ReadLine();

                            Console.Write("Enter Location: ");
                            newJob.Location = Console.ReadLine();

                            jobs[count] = newJob;
                            count++;

                            Console.WriteLine("Job posted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Job list is full. Cannot post more jobs.");
                        }
                        break;

                    case "D":
                        Console.WriteLine("Posted Jobs ");
                        if (count == 0)
                        {
                            Console.WriteLine("No jobs posted yet.");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"Job #{i + 1}");
                                Console.WriteLine($"Title: {jobs[i].JobTitle}");
                                Console.WriteLine($"Company: {jobs[i].Company}");
                                Console.WriteLine($"Location: {jobs[i].Location}");
                            }
                        }
                        break;

                   
                }

                Console.Write("Do you want to continue? (Y/N): ");
                continueAnswer = Console.ReadLine().ToUpper();

            } while (continueAnswer == "Y");
        }
    }
}
