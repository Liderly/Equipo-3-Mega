namespace backend.src.DTO
{
    public class LoginResponse
    {
        public string token { get; set; }
        public string role { get; set; }
        public int numEmp { get; set; }
        public string Message { get; set; }
    }
}
