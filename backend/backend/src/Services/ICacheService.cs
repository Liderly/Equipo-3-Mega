

namespace backend.src.Services
{
    public interface ICacheService
    {
        Task SetCache<T>(T data, string cacheKey);
        Task<T> GetCache<T>(string cacheKey);
    }
}
