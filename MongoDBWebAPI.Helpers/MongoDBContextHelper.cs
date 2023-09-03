using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Helpers
{
    public static class MongoDBContextHelper
    {
        public static MongoClient _mongoClient = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase _database = _mongoClient.GetDatabase("MongoDB"); 
    }
}
