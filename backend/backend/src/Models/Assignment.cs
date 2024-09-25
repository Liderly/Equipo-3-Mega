using Backend.Models;

namespace backend.Models
{
    public class Assignment
    {
        public int id { get; set; }
        public DateTime Assigment_date { get; set; }
        public int technician_id { get; set; }
        public int subscriber_id { get; set; }
        public int service_id { get; set; }
        public required string status_assigment { get; set; }

        public  Technician? Technician { get; set; }
        public  Suscriber? Subscriptor { get; set; }
        public  ServiceCatalog? ServiceCatalog { get; set; }
    }
}
