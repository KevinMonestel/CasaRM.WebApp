using Microsoft.AspNetCore.Identity;

namespace CasaRM.WebApp.Persistence.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Host> Host { get; set; }
    }
}
