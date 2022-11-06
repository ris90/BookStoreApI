using System;
using MongoDB.Driver;
using StudentProfileApi.Models;

namespace StudentProfileApi.Data
{
    public interface IDbClient
    { 
        IMongoDatabase GetDatabase();
    }
}
