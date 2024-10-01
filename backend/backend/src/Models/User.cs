namespace backend.src.Models;

using BCrypt.Net;
public class User
{
    public int Id { get; set; }
    public string email { get; set; }
    public string num_emp { get; set; }
    public string Password { get; set; }
    public string role { get; set; }
    
}
