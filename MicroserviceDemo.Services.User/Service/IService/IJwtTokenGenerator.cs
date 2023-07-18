using MicroserviceDemo.Services.AuthApi.Models;

namespace MicroserviceDemo.Services.AuthApi.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
