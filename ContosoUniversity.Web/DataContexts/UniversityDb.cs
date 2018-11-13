using ContosoUniversity.Entities;
using System.Data.Entity;

namespace ContosoUniversity.Web.DataContexts
{
    public class UniversityDb
    {
        public UniversityDb() { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
    }
}