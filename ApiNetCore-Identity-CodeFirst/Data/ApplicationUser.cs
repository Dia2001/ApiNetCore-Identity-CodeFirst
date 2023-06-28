using Microsoft.AspNetCore.Identity;

namespace ApiNetCore_Identity_CodeFirst.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
