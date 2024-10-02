
using backend.src.DTO;

public interface IAuthService
{
    Task<LoginResponse> Login(string email, string password); 
    Task<bool> ValidateToken(string token); 
}
