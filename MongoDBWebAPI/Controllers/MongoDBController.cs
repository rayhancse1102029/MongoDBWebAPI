using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDBWebAPI.Data;
using MongoDBWebAPI.Data.Entity;
using MongoDBWebAPI.Helpers;
using MongoDBWebAPI.Models;
using MongoDBWebAPI.Services;
using MongoDBWebAPI.Services.Interfaces;

namespace MongoDBWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MongoDBController : ControllerBase
    {
        private readonly IMongoCollection<Student> _students;

        public MongoDBController()
        {
            _students = MongoDBContextHelper._database.GetCollection<Student>("studentcourses");
        }
        // POST api/<StudentsController>
        [HttpPost]
        [Route("CreateStudent")]
        public ActionResult<Student> CreateStudent([FromBody] Student student)
        {
            try
            {
                _students.InsertOne(student);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllStudents")]
        public List<Student> GetAllStudents()
        {
            return _students.Find(student => true).ToList();
        }

    }
}
