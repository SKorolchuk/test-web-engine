using Microsoft.AspNet.Identity.EntityFramework;

namespace TestWebEngine.Data.Contexts.Authorization
{
    public class User : IdentityUser
    {
        public int? Age { get; set; }

        public string Organization { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
