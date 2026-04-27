using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Student
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Email {  get; set; }
        public List<Course> EnrolledCourses = new List<Course>();

        public Student(int id,string name,string email)
        {
            Id= id;
            Name= name;
            Email= email;
            
        }
    }
}
