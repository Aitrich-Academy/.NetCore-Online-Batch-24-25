using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Student
    {
        [Key]
       public  int Id { get; set; }
      public  int Age { get; set; }
       public string Name { get; set; }
    }
}
