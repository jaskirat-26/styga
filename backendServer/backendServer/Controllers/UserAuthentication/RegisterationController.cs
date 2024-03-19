using backendServer.Models;
using Microsoft.AspNetCore.Mvc;
using PostgreSQL.Data;

namespace backendServer.Controllers.UserAuthentication
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegistrationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public async Task<IActionResult> RegisterConsumer([FromForm] IFormCollection formData)
        {
            if (formData == null || formData.Count == 0)
            {
                return BadRequest("Form data is null or empty");
            }

            var customer = new Customer
            {
                FirstName = formData["FirstName"],
                LastName = formData["LastName"],
                EmailID = formData["EmailId"],
                CreatedAt = DateTime.UtcNow, // Use DateTime.UtcNow for current timestamp,
            };

            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
