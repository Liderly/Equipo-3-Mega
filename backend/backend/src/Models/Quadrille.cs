namespace backend.Models
{
    public class Quadrille
    {
        public int Id { get; set; }
        public int quadrille_number { get; set; }

        public  ICollection<Technician>? Technicians { get; set; }
    }
}
