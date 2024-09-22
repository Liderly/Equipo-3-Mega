namespace backend.Models
{
    public class Quadrille
    {
        public int Id { get; set; }
        public int quadrille_number { get; set; }
        public required string   region { get; set; }
        public  required string branch_office { get; set; }
        public required string state_quadrille { get; set; }

        public  ICollection<Technician>? Technicians { get; set; }
    }
}
