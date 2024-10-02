using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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
    /// <summary>
    /// Autentica a un usuario y genera un token JWT.
    /// </summary>
    /// <param name="request">Objeto LoginRequest que contiene el email y la contraseña del usuario.</param>
    /// <returns>Un token JWT y el rol del usuario si la autenticación es exitosa; de lo contrario, retorna Unauthorized.</returns>
    /// <response code="200">Retorna el token JWT y el rol del usuario.</response>
    /// <response code="401">Si las credenciales son inválidas.</response>
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var response = await _authService.Login(request.Email, request.Password);
        if (response == null)
        {
            return Unauthorized(new { message="Correo o contraseña incorrectos"});
        }

        // Retornar el token y el rol del usuario 
        return Ok(response);
    }

    /// <summary>
    /// Valida un token JWT.
    /// </summary>
    /// <param name="request">Objeto TokenRequest que contiene el token a validar.</param>
    /// <returns>Un mensaje indicando si el token es válido o no.</returns>
    /// <response code="200">Si el token es válido.</response>
    /// <response code="401">Si el token es inválido.</response>
    [HttpPost("validate")]
    public async Task<IActionResult> ValidateToken([FromBody] TokenRequest request)
    {
        var isValid= await _authService.ValidateToken(request.Token);
        if (!isValid)
        {
            return Unauthorized(new { Message="Token inválido"});
        }

        

        return Ok(new { Message ="token es valido",token=request.Token});
    }
}
