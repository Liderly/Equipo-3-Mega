namespace backend.Models
{
    public class JobsCatalog
    {
        public int id { get; set; }
        public required string name { get; set; }
        public int duration { get; set; }
        public required string description { get; set; }
        public int points { get; set; }

        public  ICollection<Assignment>? Assignments { get; set; }
    }
}
