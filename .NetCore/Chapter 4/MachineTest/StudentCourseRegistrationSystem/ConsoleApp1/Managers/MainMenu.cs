using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Managers
{
    public class MainMenu
    {
        CourseRepository courseRepo=new CourseRepository();
        StudentRepository studentRepo=new StudentRepository();
        CourseManager courseManager=new CourseManager();
        StudentManager studentManager=new StudentManager();


        public void ShowMenu()
        {

            string choice = "";
            do
            {
                Console.WriteLine("............ MAIN MENU ...........");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Remove Course");
                Console.WriteLine("3. Display Courses");
                Console.WriteLine("4. Register Student");
                Console.WriteLine("5. Enroll Course for Student");
                Console.WriteLine("6. Drop Course for Student");
                Console.WriteLine("7. View Student Courses");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Your Choice:");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        courseManager.AddCourse();
                        break;
                    case "2":
                        courseManager.RemoveCourse();
                        break;
                    case "3":
                        courseManager.DisplayCourse();
                        break;
                    case "4":
                        studentManager.RegisterStudent();
                        break;
                    case "5":
                        studentManager.EnrollCourse();
                        break;
                    case "6":
                        studentManager.DropCourse();
                        break;
                    case "7":
                        studentManager.ViewStudentCourses();
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                }
            } while (choice != "0");
        }
    }
}
