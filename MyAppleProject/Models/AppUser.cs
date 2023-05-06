using Microsoft.AspNetCore.Identity;

namespace MyAppleProject.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public string Store { get; set; }
    }
}
