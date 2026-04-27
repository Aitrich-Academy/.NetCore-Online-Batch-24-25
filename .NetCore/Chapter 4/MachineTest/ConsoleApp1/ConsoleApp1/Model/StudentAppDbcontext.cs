using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ConsoleApp1.Model
{
    public class StudentAppDbcontext : DbContext
    {
        public DbSet<Student> Students { get; set; } //table name students.student is the entity class name

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-4BTVKFHO;Initial Catalog=films;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
