using System.Data.Entity;
using ContosoUniversity.Entities;

namespace ContosoUniversity.Web.DataContexts
{
    public class UniversityDb : DbContext
    {
        public UniversityDb() : base(nameOrConnectionString: "DefaultConnection")
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().ToTable("Student", "University");
            modelBuilder.Entity<Course>().ToTable("Course", "University");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment", "University");
        }
    }
}