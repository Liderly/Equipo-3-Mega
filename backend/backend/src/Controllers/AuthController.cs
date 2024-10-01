using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    // POST api/auth/login
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var token = await _authService.Login(request.Email, request.Password);
        if (token == null)
        {
            return Unauthorized("Usuario o contraseña incorrectos");
        }

        // Retornar el token y el rol del usuario 
        return Ok(new { token });
    }

    // POST api/auth/validate
    [HttpPost("validate")]
    public async Task<IActionResult> ValidateToken([FromBody] TokenRequest request)
    {
        var isValid = await _authService.ValidateToken(request.Token);
        if (!isValid)
        {
            return Unauthorized("Token inválido");
        }

        return Ok("Token válido");
    }
}
