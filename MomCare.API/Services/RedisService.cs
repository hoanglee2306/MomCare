namespace MomCare.API.Services;

public class RedisService : IRedisService
{
    private readonly IDatabase _redisDatabase;

    public RedisService(IConnectionMultiplexer redis)
    {
        _redisDatabase = redis.GetDatabase();
    }

    public async Task<bool> SaveRegistrationInfo(string email, string password, string fullName, string phoneNumber)
    {
        var userInfo = new RegistrationInfo
        {
            Password = password,
            FullName = fullName,
            PhoneNumber = phoneNumber
        };

        string redisKey = $"registration:{email}";
        var jsonData = JsonConvert.SerializeObject(userInfo);
        return await _redisDatabase.StringSetAsync(redisKey, jsonData, TimeSpan.FromMinutes(5));
    }

    public async Task<string?> GetRegistrationInfo(string email)
    {
        string redisKey = $"registration:{email}";
        return await _redisDatabase.StringGetAsync(redisKey);
    }

    public async Task<bool> DeleteRegistrationInfo(string email)
    {
        return await _redisDatabase.KeyDeleteAsync(email);
    }
}