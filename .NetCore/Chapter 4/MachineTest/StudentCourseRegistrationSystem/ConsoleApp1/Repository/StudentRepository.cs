using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public class StudentRepository
    {
        public List<Student> Students = new List<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public Student GetStudent(int id)
        {
            foreach (var s in Students)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }
    }
}
