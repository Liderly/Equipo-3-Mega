
namespace backend.src.DTO
{
    public class BonusReport
    {
        public ICollection<TechInfo>? technitians { get; set; }
        public int Total_Technicians { get; set; }
        public class TechInfo
        {
            public int NumTech { get; set; }
            public string name { get; set; }
            public int crew { get; set; }
            public decimal TotalBonus { get; set; }
            public int TotalPoints { get; set; }
            public ICollection<Tasks> tasks { get; set; }
        }
        public class Tasks 
        {
            public int assigmentId { get; set; }
            public string description { get; set; }
            public string Client_name { get; set; }
            public string client_address { get; set; }
            public string status { get; set; }
            public string assigned_date { get; set; }
            public int points { get; set; }
        
        }
    }
    
}
