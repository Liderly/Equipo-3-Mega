using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Backend.Context;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using backend.src.Models;
using backend.src.DTO;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

public class AuthService : IAuthService
{
    private readonly ContextDB _context;
    private readonly TokenService _tokenService;
    private readonly IConfiguration _configuration;

    public AuthService(ContextDB context, TokenService tokenService,IConfiguration configuration)
    {
        _context = context;
        _tokenService = tokenService;
        _configuration = configuration;
    }

    public async Task<LoginResponse> Login(string email, string password)
    {
        try {
            LoginResponse resp = new LoginResponse();
        // Buscar el usuario en la base de datos
        var user = await _context.Users.SingleOrDefaultAsync(u => u.email == email);

        // Verificar si el usuario existe y si la contraseña es correcta
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.password))
        {
            return null; // o lanza una excepción si prefieres
        }

        // Generar y retornar el token
        string token = _tokenService.GenerateToken(user);
            resp.token = token;
            resp.role = user.role;
            resp.numEmp = user.num_emp;
            resp.Message = "Login exitoso";
            return resp;
        }catch(Exception e){
            return null;
        }
    }

    public async Task<bool> ValidateToken(string token)
    {
        if (string.IsNullOrEmpty(token))
            return false;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]); // Clave secreta que usaste para firmar el token

        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key), // Clave usada para verificar la firma
                ValidateIssuer = false, // Configura esto si quieres validar el emisor
                ValidateAudience = false, // Configura esto si quieres validar la audiencia
                ClockSkew = TimeSpan.Zero, // Elimina la tolerancia de tiempo por defecto
                ValidateLifetime = true, // Valida que el token no haya expirado
                RequireExpirationTime = true, // Asegura que el token tenga una fecha de expiración
            }, out SecurityToken validatedToken);

            // Si llegamos hasta aquí, el token es válido
            return true;
        }
        catch (Exception ex)
        {
            // Captura los posibles errores de validación, por ejemplo, token expirado o firma no válida
            Console.WriteLine($"Error al validar el token: {ex.Message}");
            return false;
        }
    }
}
