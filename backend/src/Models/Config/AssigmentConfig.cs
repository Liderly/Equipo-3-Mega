namespace Backend.Models.Config
{
    public class AssigmentConfig
    {
        public int id { get; set; }
        public int technician_id { get; set; }
        public int subscriber_id { get; set; }
        public int service_id { get; set; }
        public string status_assigment { get; set; }
    }
}