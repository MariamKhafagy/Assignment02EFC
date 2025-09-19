using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=true;");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
          => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
    }
}
