using backend.Models;
using backend.src.DTO;
using Backend.DTO;

namespace Backend.Services

{
    public interface ITaskService
    {
        Task<AssignmentDto> CreateTask(CreateTaskDto task);
        Task<AssignmentDto> UpdateTask(int id, UpdateTaskDto task);
        Task<Assignment> DeleteTask(int id);
    }
}