using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public class CourseRepository
    {
       public List<Course> Courses=new List<Course>();


        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }


        public Course GetCourse(int id)
        {
            foreach (var c in Courses)
            {
                if (c.Id == id)
                    return c;
            }
            return null;
        }

        public List<Course> GetAllCourses()
        {
            return Courses;
        }
    }
}
