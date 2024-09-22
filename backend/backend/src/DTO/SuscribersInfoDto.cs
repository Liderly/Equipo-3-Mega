namespace backend.src.DTO
{
    public class SubscriberResponse { 
    public List<SuscribersInfoDto> subscribers { get; set; }
    public int Elements { get; set; }
    }
    public class SuscribersInfoDto : ISuscribersInfoDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lasst_name { get; set; }
        public string street { get; set; }
        public int post_Code { get; set; }
        public string zone_sub { get; set; }
        public List<AssigmentsDetails> assigments { get; set; }
       
    }
    public class AssigmentsDetails
    {
        public string assignment_date { get; set; }
        public string assignment_status { get; set; }
        public string assignment_type { get; set; }
    }
}