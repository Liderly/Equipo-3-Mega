namespace backend.src.DTO
{
    public class PaginateProps
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public string SortBy { get; set; }= "id";
        public string SortDirection { get; set; } = "asc";
    }
}
