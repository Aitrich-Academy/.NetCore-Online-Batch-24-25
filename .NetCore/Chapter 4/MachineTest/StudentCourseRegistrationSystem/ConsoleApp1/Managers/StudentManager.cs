using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using StudentCourseRegistrationSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Managers
{
    public class StudentManager
    {
        private StudentRepository studentRepo;
        private CourseRepository courseRepo;

        public StudentManager(StudentRepository studentRepo, CourseRepository courseRepo)
        {
            this.studentRepo = studentRepo;
            this.courseRepo = courseRepo;
        }

        public void RegisterStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Student student=new Student(id, name, email);
            studentRepo.AddStudent(student);
            Console.WriteLine("Student registered successfully!");

        }


        public void EnrollCourse()
        {
           
            try
            {
                Console.Write("Enter Student ID: ");
                int studentId = Convert.ToInt32(Console.ReadLine());

                Student student = studentRepo.GetStudent(studentId);
                if (student == null)
                {
                    throw new Exception("Student not found!");
                }

                Console.Write("Enter Course ID to enroll: ");
                int courseId = Convert.ToInt32(Console.ReadLine());

                Course course = courseRepo.GetCourse(courseId);

                if (course == null)
                {
                    throw new Exception("Course not found!");
                }

                if (student.EnrolledCourses.Contains(course))
                {
                    throw new CourseAlreadyRegisteredException("You are already enrolled in this course!");

                }
                   

                student.EnrolledCourses.Add(course);
                Console.WriteLine(" Course enrolled successfully!");
            }
            catch (CourseAlreadyRegisteredException ex)
            {
                Console.WriteLine($" {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }


        public void DropCourse()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Student student = studentRepo.GetStudent(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            Console.Write("Enter Course ID to drop: ");
            int courseId = int.Parse(Console.ReadLine());

            Course courseToRemove = null;
            foreach (var c in student.EnrolledCourses)
            {
                if (c.Id == courseId)
                {
                    courseToRemove = c;
                    break;
                }
            }

            if (courseToRemove != null)
            {
                student.EnrolledCourses.Remove(courseToRemove);
                Console.WriteLine("Course dropped successfully");
            }
            else
            {
                Console.WriteLine("Course not found in student's list");

            }
        }


        public void ViewStudentCourses()
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Student student = studentRepo.GetStudent(studentId);

            if (student == null)
            {
                {
                    Console.WriteLine("student not found");
                    return;
                }

                Console.WriteLine($" Courses for {student.Name}:");
                if (student.EnrolledCourses.Count == 0)
                {
                    Console.WriteLine("No courses enrolled.");
                    return;
                }

              
            }

            foreach (var c in student.EnrolledCourses)
            {
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}, Instructor: {c.Instructor}, Credits: {c.Credits}");
            }

        }
    }
    
}
