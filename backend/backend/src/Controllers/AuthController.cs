using backend.src.DTO;
using backend.src.Models;
using backend.src.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;
    private readonly IUserService _userService;
    private readonly ITokenService  _tokenService;


    public AuthController(AuthService authService, IUserService userService, ITokenService tokenService)
    {
        _authService = authService;
        _userService = userService;
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] User loginRequest)
    {
        if (loginRequest == null || string.IsNullOrEmpty(loginRequest.email) || string.IsNullOrEmpty(loginRequest.Password))
        {
            return BadRequest("Credenciales inválidas.");
        }

        var isValidUser = await _authService.ValidateUserCredentials(loginRequest);
        if (!isValidUser)
        {
            return Unauthorized();
        }

        // Aquí puedes agregar la lógica para generar un token JWT o similar si es necesario

        return Ok("Inicio de sesión exitoso.");
    }

    [HttpPost("login2")] //endpoint para el login
    public IActionResult Login2([FromBody] User userLogin)
    {
        // Buscar usuario en la base de datos (usando Email)
        var user = _userService.GetUserByEmail(userLogin.email);
        if (user == null)
        {
            return Unauthorized("Invalid email or password");
        }

        // Verificar contraseña
        if (!user.VerifyPassword(userLogin.Password))
        {
            return Unauthorized("Invalid email or password");
        }

        // Generar token
        var token = _tokenService.GenerateToken(user);

        return Ok(new { Token = token });
    }

}
