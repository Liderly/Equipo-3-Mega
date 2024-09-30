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

    public AuthController(AuthService authService)
    {
        _authService = authService;
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
}
