using Microsoft.AspNetCore.Identity;

namespace LoginApp.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
