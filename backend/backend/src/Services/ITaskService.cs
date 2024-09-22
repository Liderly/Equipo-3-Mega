using backend.src.DTO;
using Backend.Models;

namespace Backend.Services

{
    public interface ITaskService
    {
        Task<IEnumerable<SuscribersInfoDto>> GetTasks(PaginateProps props);
        // Task<Task> GetTask(int id);
        // Task<Task> CreateTask(Task task);
        // Task<Task> UpdateTask(int id, Task task);
        // Task<Task> DeleteTask(int id);
    }
}