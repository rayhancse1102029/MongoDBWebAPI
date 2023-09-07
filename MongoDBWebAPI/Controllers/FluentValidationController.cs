using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBWebAPI.Models;

namespace MongoDBWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FluentValidationController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            // Validate the product
            var validator = new ProductValidator();
            var validationResult = validator.Validate(product);

            if (!validationResult.IsValid)
            {
                // If validation fails, return the error messages to the user
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                return BadRequest(product);
            }

            // If validation passes, perform the action (e.g., save to the database)
            // ...

            return Ok();
        }
    }
}
