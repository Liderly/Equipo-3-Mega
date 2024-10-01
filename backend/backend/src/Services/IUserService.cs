namespace backend.src.Services
// Interfaz
public interface IUserService
{
    User GetUserByEmail(string email);
}

// Implementación
public class UserService : IUserService
{
    private readonly DbContext _context; // Usa tu DbContext aquí

    public UserService(DbContext context)
    {
        _context = context;
    }

    public User GetUserByEmail(string email)
    {
        return _context.Users.SingleOrDefault(u => u.email == email); // Asegúrate de tener esta propiedad en tu DbContext
    }
}

