/*using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ContosoUniversity.Web.Models;

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

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
*/