using System.Threading.Tasks;
using backend.src.Models;
using Backend.Models;
using Microsoft.AspNetCore.Identity;

public class AuthService
{
    private readonly UserManager<User> _userManager; 

    public AuthService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> ValidateUserCredentials(User loginRequest)
    {
        var user = await _userManager.FindByEmailAsync(loginRequest.email);
        if (user == null) return false;

        // Aquí podrías agregar la lógica para verificar la contraseña
        return await _userManager.CheckPasswordAsync(user, loginRequest.Password);
    }
}
