using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Backend.Context;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using backend.src.Models;

public class AuthService : IAuthService
{
    private readonly ContextDB _context;
    private readonly TokenService _tokenService;

    public AuthService(ContextDB context, TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<string> Login(string email, string password)
    {
        // Buscar el usuario en la base de datos
        var user = await _context.Users.SingleOrDefaultAsync(u => u.email == email);

        // Verificar si el usuario existe y si la contraseña es correcta
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return null; // o lanza una excepción si prefieres
        }

        // Generar y retornar el token
        return _tokenService.GenerateToken(user);
    }

    public async Task<bool> ValidateToken(string token)
    {
        // Aqui va la lógica para validar el token, si es necesario
        return true; // Ejemplo: retornar true si el token es válido
    }
}
