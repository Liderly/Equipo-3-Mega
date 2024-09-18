namespace Backend.DTO
{
    public interface ITaskDto
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
    }
}