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

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUser", "Identity");
            modelBuilder.Entity<IdentityRole>().ToTable("AspNetRole", "Identity");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("AspNetUserLogin", "Identity");
            modelBuilder.Entity<IdentityUserRole>().ToTable("AspNetUserRole", "Identity");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("AspNetUserClaim", "Identity");
        }
    }
}