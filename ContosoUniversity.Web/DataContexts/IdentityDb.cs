using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ContosoUniversity.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ContosoUniversity.Web.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb() { }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Identity");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUser");
            modelBuilder.Entity<IdentityRole>().ToTable("AspNetRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("AspNetUserLogin");
            modelBuilder.Entity<IdentityUserRole>().ToTable("AspNetUserRole");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("AspNetUserClaim");
        }
    }
}