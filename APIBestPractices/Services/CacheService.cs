using System.Text.Json;

namespace APIBestPractices.Services
{
    public class CacheService
    {
        private readonly Dictionary<string, string> _cache = new();

        public string? GetCacheValue(string key)
        {
            _cache.TryGetValue(key, out var value);
            return value;
        }

        public void SetCacheValue(string key, string value)
        {
            _cache[key] = value;
        }
    }
}

