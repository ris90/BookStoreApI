using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace StudentProfileApi.Data
{
    public class DbClient : IDbClient
    {
        private readonly IMongoDatabase _database;
        public DbClient(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["StudentAppCon:StudentAppCon"]);
            _database = client.GetDatabase(configuration["StudentAppCon:StudentDatabase"]);
        }
        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
