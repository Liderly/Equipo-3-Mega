using backend.src.Models;

namespace backend.src.Services
{
    public class UserService : IUserService
    {
        // Aquí debes tener la lógica para validar usuarios contra la base de datos
        public User ValidateUser(string email, string password)
        {
            // Lógica para obtener al usuario desde la base de datos y verificar la contraseña
            var user = GetUserFromDatabase(email); // Reemplaza con tu método para obtener el usuario
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return null;
            }
            return user;
        }

        private User GetUserFromDatabase(string email)
        {
            // Lógica para obtener el usuario desde la base de datos
            return new User { email = email, Password = BCrypt.Net.BCrypt.HashPassword("1234") };
        }
    }
}
