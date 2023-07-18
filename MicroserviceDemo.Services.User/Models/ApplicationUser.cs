using Microsoft.AspNetCore.Identity;

namespace MicroserviceDemo.Services.AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
