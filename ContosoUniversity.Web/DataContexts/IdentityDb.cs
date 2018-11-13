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
    }
}