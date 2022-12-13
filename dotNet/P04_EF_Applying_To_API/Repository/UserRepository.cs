using Microsoft.IdentityModel.Tokens;
using P04_EF_Applying_To_API.Data;
using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Repository.IRepository;
using P04_EF_Applying_To_API.Services.IService;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace P04_EF_Applying_To_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantContext _db;
        private IPasswordService _passwordService;
        private IJwtService _jwtService;
        public UserRepository(RestaurantContext db, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService = jwtService;
        }
        public bool IsUniqueUser(string username)
        {
            var user = _db.LocalUsers.FirstOrDefault(x => x.Username == username);

            if(user == null)
            {
                return true;
            }
            return false;
        }

        public LoginResponse Login(LoginRequest loginRequest)
        {
            var inputPasswordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = _db.LocalUsers.FirstOrDefault(x => x.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null && !_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt))
            {
                return new LoginResponse
                {
                    Token = "",
                    User = null
                };
            }

            var token = _jwtService.GetJwtToken(user.Id, user.Role);
            LoginResponse loginResponse = new()
            {
                Token = token,
                User = user
            };

            loginResponse.User.PasswordHash = null;

            return loginResponse;
        }

        // Add RegistrationResponse (Should not include password)
        // Add adapter classes to map to wanted classes
        public LocalUser Register(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);
            LocalUser user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Name = registrationRequest.Name,
                Role = registrationRequest.Role
            };
            _db.LocalUsers.Add(user);
            _db.SaveChanges();
            user.PasswordHash = null;
            return user;
        }
    }
}
