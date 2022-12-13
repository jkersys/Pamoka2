using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Repository.IRepository;

namespace P04_EF_Applying_To_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginRequest model)
        {
            var loginResponse = _userRepo.Login(model);
            if(loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { message = "Username or password is incorect" });
            }
            return Ok(loginResponse);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegistrationRequest model)
        {
            var isUserUnique = _userRepo.IsUniqueUser(model.Username);

            if(!isUserUnique)
            {
                return BadRequest(new { message = "User already exist" });
            }
            var user = _userRepo.Register(model);

            if(user == null)
            {
                return BadRequest(new { message = "Error while registering" });
            }
            return Ok();

        }

    }
}
