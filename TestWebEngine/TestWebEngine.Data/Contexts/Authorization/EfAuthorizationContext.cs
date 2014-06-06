using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TestWebEngine.Data.Contexts.Authorization
{
    public class EfAuthorizationContext : IdentityDbContext<User>
    {
        public EfAuthorizationContext(string connectionStringOrName = "defaultConnection")
            : base(connectionStringOrName)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new User_Mapping());
        }

        public static EfAuthorizationContext Create()
        {
            return new EfAuthorizationContext();
        }
    }
}
