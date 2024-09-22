using backend.src.DTO;

namespace backend.src.Services
{
        public interface ISuscriberService
        {
            Task<SubscriberResponse> GetSubscribers(PaginateProps props);
            Task<SuscribersInfoDto> GetSuscriberById(int id);
        // Task<Task> CreateTask(Task task);
        // Task<Task> UpdateTask(int id, Task task);
        // Task<Task> DeleteTask(int id);
    }
}
