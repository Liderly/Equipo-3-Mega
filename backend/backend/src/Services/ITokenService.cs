using backend.Models;
namespace backend.src.Services;

{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
