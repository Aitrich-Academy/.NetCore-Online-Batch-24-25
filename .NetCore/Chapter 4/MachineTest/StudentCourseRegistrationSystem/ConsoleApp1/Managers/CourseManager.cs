using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Managers
{
    public class CourseManager:ICourseManager
    {
        private CourseRepository courseRepo;

        public CourseManager(CourseRepository courseRepo)
        {
            this.courseRepo = courseRepo;
        }


        public void AddCourse()
        {
            Console.Write("Enter Course ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Instructor: ");
            string instructor = Console.ReadLine();
            Console.Write("Enter Credits: ");
            int credits = Convert.ToInt32(Console.ReadLine());

            Course course = new Course(id, name, instructor, credits);

            courseRepo.AddCourse(course);

            Console.WriteLine("Course added successfully!");
        }


        public void RemoveCourse()

        {
            Console.Write("Enter course id to Remove:");
            int id= Convert.ToInt32(Console.ReadLine());

            Course course=courseRepo.GetCourse(id);

            if (course != null)
            {
                courseRepo.GetAllCourses().Remove(course);
                Console.WriteLine(" Course removed successfully!");
            }
            else
            {
                Console.WriteLine("Course not found!");
            }

        }


        public void DisplayCourse()
        {
            var courses = courseRepo.GetAllCourses();
            Console.WriteLine(" All Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.Id}, Name: {course.Name}, Instructor: {course.Instructor}, Credits: {course.Credits}");
            }
        }
    }
}
