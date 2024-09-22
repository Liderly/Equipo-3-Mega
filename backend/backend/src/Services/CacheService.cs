using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi.Any;
using System.IO.Compression;
using System.Text.Json;

namespace backend.src.Services
{
    public class CacheService : ICacheService
    {
        private readonly IDistributedCache _cache;
        private readonly IMemoryCache _cacheMemory;
        public CacheService(IDistributedCache cache, IMemoryCache cacheMemory)
        {
            _cache = cache;
            _cacheMemory = cacheMemory;
        }
        public async  Task SetCache<T>(T data, string cacheKey) {
            byte[] serializedMovies = JsonSerializer.SerializeToUtf8Bytes(data);
            byte[] compressedMovies = Compress(serializedMovies);
            //CONFIGURACION DE CACHE EN REDIS
            var options = new DistributedCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(60))
                .SetSlidingExpiration(TimeSpan.FromMinutes(60));
            ///CONFIGURACION DE CACHE EN MEMORIA
            var cacheMemoryOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromMinutes(10))
            .SetSlidingExpiration(TimeSpan.FromMinutes(10));
            await _cache.SetAsync(cacheKey, compressedMovies, options);
            _cacheMemory.Set(cacheKey, compressedMovies, cacheMemoryOptions);
        }
        public async Task<T> GetCache<T>(string cacheKey)
        {
            try
            {
                // Buscar en caché local
                if (_cacheMemory.TryGetValue(cacheKey, out byte[] cachedData))
                {
                    byte[] decompressedMovies = Decompress(cachedData);
                    T Data = JsonSerializer.Deserialize<T>(decompressedMovies);
                    return Data;
                }
                // Buscar en Redis
                byte[] redisData = await _cache.GetAsync(cacheKey);
                if (redisData != null)
                {
                    byte[] decompressedData = Decompress(redisData);
                    T redisResult = JsonSerializer.Deserialize<T>(decompressedData);
                    // Guardar en caché local para futuras consultas
                    _cacheMemory.Set(
                        cacheKey, 
                        redisResult, 
                        new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(10)).SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));
                    return redisResult;
                }
                // No se encontró en ninguna caché
                return default;
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error retrieving cache: {ex.Message}");
                return default;
            }
        }

        private static byte[] Compress(byte[] data)
        {
            using var memoryStream = new MemoryStream();
            using (var gzipStream = new GZipStream(memoryStream, CompressionLevel.Fastest))
            {
                gzipStream.Write(data, 0, data.Length);
            }
            return memoryStream.ToArray();
        }
        private static byte[] Decompress(byte[] data)
        {
            using var compressedStream = new MemoryStream(data);
            using var decompressStream = new MemoryStream();
            using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            {
                gzipStream.CopyTo(decompressStream);
            }
            return decompressStream.ToArray();
        }
    }
}
