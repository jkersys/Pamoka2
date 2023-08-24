using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.LocalUserDto;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Service.IService;
using System.Security.Claims;

namespace RPTS_sistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IJwtService _jwtService;
        private readonly ILogger<UserController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserAdapter _userAdapter;

        public UserController(IUserRepository userRepo, IJwtService jwtService, ILogger<UserController> logger, IHttpContextAccessor httpContextAccessor, IUserAdapter userAdapter)
        {
            _userRepo = userRepo;
            _jwtService = jwtService;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _userAdapter = userAdapter;
        }

        /// <summary>
        /// Tikrina vartotojo prisiloginima, ar sutampa vartotojo email ir password su duomenu bazeje esanciais 
        /// </summary>
        /// <param name="model">email and password</param> 
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost("login")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            try
            {
                _logger.LogInformation("User {date} tried login with {model} email adress", DateTime.Now, model.Email);
                var loginResponse = await _userRepo.LoginAsync(model);


                if (loginResponse.Email == null || string.IsNullOrEmpty(loginResponse.Token))
                {
                    return BadRequest(new { message = "Username or password is incorrect" });
                }
                return Ok(loginResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} Login exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Vartotojo regisracija, atliekant patikrinima ar vartotojo su tokiu pat Email nera duomenu bazeje
        /// </summary>
        /// <param name="model">email, name, lastname, password</param>
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("register")]
        // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest model)
        {
            try
            {
                _logger.LogInformation("User {date} tried registrate with {model} email adress", DateTime.Now, model.Email);
                var isUserNameUnique = await _userRepo.IsUniqueUserAsync(model.Email);

                if (!isUserNameUnique)
                {
                    return BadRequest(new { message = "User already exists" });
                }

                var user = await _userRepo.RegisterAsync(model);

                if (user == null)
                {
                    return BadRequest(new { message = "Error while registering" });
                }

                return Created(nameof(Login), new { id = user.Id });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.Now} Registration exception error.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Vartojojo slaptažodžio keitimas 
        /// </summary>
        /// <param name="model">id, password</param>
        /// <returns></returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("changepassword")]
        [Authorize]

        public async Task<ActionResult> ChangePassword([FromBody] ChangePassword changePassword)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
            var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            LocalUser? user;

            if (currentUserRole == "Admin" || currentUserRole == "Director")
            {
                user = await _userRepo.GetUserById(changePassword.Id);
            }
            if (currentUserRole == "Investigator")
            {
                user = await _userRepo.GetUserById(currentUserId);
            }
            else return BadRequest(new { message = "User not exist" });

           await _userRepo.ChangePasswordAsync(user, changePassword);

            return Ok(new {message = "Password Changed" });
        }

        /// <summary>
        /// Get metodas naudojamas front ende, kad butu paduodami tyrejai scrolldownui, 
        /// kuriuo parenkamas duomenu pazeje esantis tyrejas ir priskiriamas tyrimui, patikrai, ar kt.
        /// </summary>
        /// <returns></returns>
        [HttpGet("users/chose")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetUsersForFrontEnd>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGetUserForFrontEndScrollDown()
        {
            var users = await _userRepo.All();

            if(users == null)
            {
                NotFound();
            }
            return Ok(users.Select(x => new GetUsersForFrontEnd(x)).ToList());
        }

        [HttpGet("users")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UsersForFEWithStatistic>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUsersWithStatistic()
        {
            var users = await _userRepo.All();

            if (users == null)
            {
                NotFound();
            }
            return Ok(users
                .Select(x => _userAdapter.BindStatistic(x))
                .ToList());
        }
    }
}
