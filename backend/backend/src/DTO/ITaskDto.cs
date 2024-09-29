namespace Backend.DTO
{
    public interface ITaskDto
    {
        int technician_id { get; set; }
        int subscriber_id { get; set; }
        int service_id { get; set; }
    }
}