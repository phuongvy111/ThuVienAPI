using Microsoft.AspNetCore.Identity;

namespace ThuVienAPI.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);

    }
}
