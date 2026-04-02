using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credits {  get; set; }

        public Course(int id,string name,string instructor,int credits)
        { 
            Id = id;
            Name = name;
            Instructor = instructor;
            Credits = credits;
        }
    }
}
