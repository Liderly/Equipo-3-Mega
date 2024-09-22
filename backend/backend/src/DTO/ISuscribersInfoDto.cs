namespace backend.src.DTO
{
    public interface ISuscribersInfoDto
    {
        int id { get; set; }
        string name { get; set; }
        string lasst_name { get; set; }
        string street { get; set; }
        int post_Code { get; set; }
        string zone_sub { get; set; }
        List<AssigmentsDetails> assigments { get; set; }
    }
}
