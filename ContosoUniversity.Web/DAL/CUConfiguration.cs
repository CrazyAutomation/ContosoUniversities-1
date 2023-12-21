using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.Web.DAL
{
    public class CUConfiguration : DbConfiguration
    {
        public CUConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}