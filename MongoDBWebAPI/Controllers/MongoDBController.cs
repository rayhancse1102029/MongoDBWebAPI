using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBWebAPI.Data;
using MongoDBWebAPI.Data.Entity;

namespace MongoDBWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoDBController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;

        public MongoDBController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        // Example: Insert a document
        [HttpPost]
        public ActionResult Insert([FromBody] User model)
        {
            //var collection = _mongoDBService.Database.GetCollection<User>("Users");
            //collection.InsertOne(model);
            return Ok();
        }

        // Implement other CRUD operations similarly

    }
}
