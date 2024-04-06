using Microsoft.AspNetCore.Identity;

namespace WebShopBackend.Application.Models
{
    public class User : IdentityUser
    {
        public string? City { get; set; }
    }
}
