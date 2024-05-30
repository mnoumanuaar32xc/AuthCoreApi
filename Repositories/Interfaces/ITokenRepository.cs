using Microsoft.AspNetCore.Identity;

namespace TraningWebApi.Repositories.Interfaces
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
