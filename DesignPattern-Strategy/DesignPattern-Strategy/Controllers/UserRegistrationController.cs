using DesignPattern_Strategy.Model;
using DesignPattern_Strategy.ValidationWithStrategy;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_Strategy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly ValidationContext _validationContext;

        public UserRegistrationController()
        {
            _validationContext = new ValidationContext();
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationRequest request)
        {
            var errors = _validationContext.Validate(request);
            if (errors.Any())
            {
                return BadRequest(new { Errors = errors });
            }

            return Ok("Registration successful!");
        }
    }
}
