using backend.Models;
using Backend.Models;

namespace Backend.DTO
{
   public class CreateTaskDto : ITaskDto
   {
        public int technician_id { get; set; }
        public int subscriber_id { get; set; }
        public int service_id { get; set; }
    }
    public class UpdateTaskDto : ITaskDto
    {
        public int technician_id { get; set; }
        public int subscriber_id { get; set; }
        public int service_id { get; set; }
        public string status { get; set; }
    }
    public class AssignmentDto
    {
        public int Id { get; set; }
        public TechnicianDto Technician { get; set; }
        public SubscriptorDto Subscriptor { get; set; }
        public JobsCatalogDto JobsCatalog { get; set; }
    }

    public class TechnicianDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int QuadrilleNumber { get; set; }
    }

    public class SubscriptorDto
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int PostCode { get; set; }
        public string Zone { get; set; }
    }

    public class JobsCatalogDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }


}
