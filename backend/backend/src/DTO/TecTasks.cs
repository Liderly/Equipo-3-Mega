
namespace backend.src.DTO
{
    public class TecTasks
    {
        public int numTech { get; set; }
        public string name { get; set; }
        public List<ServiceInfo>? tasks { get; set; }
    }
    public class ServiceInfo
    {
        public string assigmentId { get; set; }
        public string client_address { get; set; }
        public string client_name { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string assigned_date { get; set; }
    }
}
       
