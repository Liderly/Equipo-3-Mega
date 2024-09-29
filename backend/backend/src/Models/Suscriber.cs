using backend.Models;

namespace Backend.Models
{
    public class Suscriber
    {
        public int id { get; set; }
        public int number { get; set; }

        public required string name { get; set; }
        public  required string last_name { get; set; }
        public required string street { get; set; }
        public required string street_number { get; set; }
        public int post_code { get; set; }
        public required string zone {get; set; }
        public long phone { get; set; }

        public  ICollection<Assignment>? Assignments { get; set; }
    }
}