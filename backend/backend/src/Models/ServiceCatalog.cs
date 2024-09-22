namespace backend.Models
{
    public class ServiceCatalog
    {
        public int id { get; set; }
        public required string service_name { get; set; }
        public int duration { get; set; }
        public required string description_service { get; set; }
        public int points { get; set; }

        public  ICollection<Assignment>? Assignments { get; set; }
    }
}
