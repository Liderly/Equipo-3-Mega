using backend.Models;

namespace Backend.Models
{
    public class Suscriber
    {
        public int id { get; set; }
        public required string name { get; set; }
        public  required string last_name { get; set; }
        public required string street { get; set; }
        public int post_Code { get; set; }
        public required string zone_sub {get; set; }

        public  ICollection<Assignment>? Assignments { get; set; }
    }
}