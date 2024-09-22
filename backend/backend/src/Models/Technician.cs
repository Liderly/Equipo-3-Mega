namespace backend.Models
{
    public class Technician
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required  string last_name { get; set; }
        public int employee_number { get; set; }
        public int? quadrille_id { get; set; }

        public  Quadrille? Quadrille { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
    }
}
