using Microsoft.AspNetCore.Identity;
using Accounting.Domain;

namespace Accounting.Persistence
{
    
    public class ApplicationUser : IdentityUser, IUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}".Trim();

        // Override UserName to always return Email (if you want them to be the same)
        public override string? UserName
        {
            get => Email;
            set => base.UserName = value;
        }
    }
}
