using System;

class JobPostingPlatform
{
    struct Job
    {
        public string Title;
        public string Company;
        public string Location;
    }

    static void Main()
    {
        
        Job[] jobs = new Job[3];
        int jobCount = 0;
        string choice;

        do
        {
            Console.WriteLine("Job Posting Platform");
            Console.WriteLine("A - Post a Job");
            Console.WriteLine("D - Display All Jobs");
          
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "A":
                    if (jobCount < maxJobs)
                    {
                        Console.Write("Enter Job Title: ");
                        jobs[jobCount].Title = Console.ReadLine();

                        Console.Write("Enter Company Name: ");
                        jobs[jobCount].Company = Console.ReadLine();

                        Console.Write("Enter Job Location: ");
                        jobs[jobCount].Location = Console.ReadLine();

                        jobCount++;
                        Console.WriteLine("Job posted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Job list is full.");
                    }
                    break;

                case "D":
                    if (jobCount == 0)
                    {
                        Console.WriteLine("No jobs have been posted yet.");
                    }
                    else
                    {
                        Console.WriteLine(" Posted Jobs");
                        for (int i = 0; i < jobCount; i++)
                        {
                            Console.WriteLine($"Job #{i + 1}");
                            Console.WriteLine($"Title   : {jobs[i].Title}");
                            Console.WriteLine($"Company : {jobs[i].Company}");
                            Console.WriteLine($"Location: {jobs[i].Location}");
                        }
                    }
                    break;

              
            }

        } 
    }
}
