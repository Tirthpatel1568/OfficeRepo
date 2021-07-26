using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext():base("name = con")
        {
            Database.SetInitializer<StudentDbContext>(new CreateDatabaseIfNotExists<StudentDbContext>());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}