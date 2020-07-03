using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data.EntityFramework.Entities
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
