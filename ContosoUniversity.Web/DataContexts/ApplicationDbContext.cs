using ContosoUniversity.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ContosoUniversity.Web.DataContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}