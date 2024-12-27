using Microsoft.AspNetCore.Identity;

namespace Login.Models
{
    public class Users:IdentityUser
    {
        public string Name { get; set; }
    }
}
