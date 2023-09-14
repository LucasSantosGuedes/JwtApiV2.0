using Microsoft.Extensions.Configuration;

namespace JwtAuthDemo
{
    public class LerKey
    {
        public string? JwtSecret { get; }

        public LerKey(IConfiguration configuration)
        {
            JwtSecret = configuration["JwtSecret"];
        }
    }
}