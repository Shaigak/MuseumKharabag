using Microsoft.AspNetCore.Identity;

namespace ProjectMuseum.Models
{
    public class AppUser:IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<BlogComment> BlogComments { get; set; }

    }
}
